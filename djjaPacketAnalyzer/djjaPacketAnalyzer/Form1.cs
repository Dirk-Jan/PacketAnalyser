using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace djjaPacketAnalyzer
{
    public partial class Form1 : Form
    {
        public bool mIsBigEndian { get { return cboxIsBigEndian.Checked; } }
        public byte[] mBuffer = null;
        private string mOFDDir = @"H:\deleteme_packets";
        // for unknown bits header
        private string mCurrentFileName = "";
        public Form1()
        {
            InitializeComponent();
            cboxSearchType.SelectedIndex = 0;
        }

        private void btnLoadPacket_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = mOFDDir;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !String.IsNullOrEmpty(ofd.FileName))
            {
                mOFDDir = Path.GetDirectoryName(ofd.FileName);
                mBuffer = File.ReadAllBytes(ofd.FileName);
                groupBox1.Enabled = true;
                tboxPacketPath.Text = ofd.FileName;
                tboxByteBuffer.Clear();
                ClearTextBoxes();
                lblPacketLength.Text = mBuffer.Length.ToString();

                foreach(byte b in mBuffer)
                    tboxByteBuffer.Text += b.ToString("X2") + " ";

                // to copy unknown bits header to clipboard
                mCurrentFileName = ofd.FileName;
                //button1_Click(null, null);
            }

        }

        private void OnSelectionChanged()
        {
            ClearTextBoxes();
            byte[] b = GetSelectedBytes();
            if (b == null) { tboxByteArray.Text = "Please completely select the bytes."; return; }

            if (!mIsBigEndian)
                b = GetFlippedArray(b, b.Length);

            lblSelectedBytesCount.Text = b.Length.ToString();
            tboxByteArray.Text = "[" + ByteArrayToString(b) + "]";
            tboxStringASCII.Text = System.Text.Encoding.ASCII.GetString(b);
            tboxStringUTF8.Text = System.Text.Encoding.UTF8.GetString(b);
            tboxStringUnicode.Text = System.Text.Encoding.Unicode.GetString(b);
            foreach (byte a in b)
            {
                tboxInt8.Text += ((sbyte)a).ToString() + " ";
                tboxUInt8.Text += a.ToString() + " ";
            }  
            /*tboxInt8.Text = ((sbyte)b[0]).ToString();
            tboxUInt8.Text = b[0].ToString();*/
            if (b.Length >= 2)
            {
                tboxInt16.Text = BitConverter.ToInt16(b, 0).ToString();
                tboxUInt16.Text = BitConverter.ToUInt16(b, 0).ToString();
            }
            if (b.Length >= 4)
            {
                tboxInt32.Text = BitConverter.ToInt32(b, 0).ToString();
                tboxUInt32.Text = BitConverter.ToUInt32(b, 0).ToString();
                tboxSingle.Text = BitConverter.ToSingle(b, 0).ToString();
            }
            if (b.Length >= 8)
            {
                tboxInt64.Text = BitConverter.ToInt64(b, 0).ToString();
                tboxUInt64.Text = BitConverter.ToUInt64(b, 0).ToString();
                tboxDouble.Text = BitConverter.ToDouble(b, 0).ToString();
            }
        }

        private byte[] GetFlippedArray(byte[] b, int length)
        {
            byte[] arr = new byte[length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = b[(length - 1) - i];
            return arr;
        }

        private void ClearTextBoxes()
        {
            tboxByteArray.Clear();
            tboxStringASCII.Clear();
            tboxStringUTF8.Clear();
            tboxStringUnicode.Clear();
            tboxInt8.Clear();
            tboxUInt8.Clear();
            tboxInt16.Clear();
            tboxUInt16.Clear();
            tboxInt32.Clear();
            tboxUInt32.Clear();
            tboxSingle.Clear();
            tboxDouble.Clear();
            tboxInt64.Clear();
            tboxUInt64.Clear();
        }

        private byte[] GetSelectedBytes()
        {
            string[] a = tboxByteBuffer.SelectedText.Trim().Split(' ');
            byte[] b = new byte[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Length != 2)
                {
                    return null;
                }
                b[i] = Convert.ToByte(a[i], 16);
            }
            return b;
        }

        private string ByteArrayToString(byte[] array)
        {
            string s = string.Empty;
            foreach (byte b in array)
                s += b.ToString("X2") + " ";
            return s.Substring(0, s.Length - 1);
        }

        private void tboxByteBuffer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OnSelectionChanged();
        }

        private void cboxIsBigEndian_CheckedChanged(object sender, EventArgs e)
        {
            OnSelectionChanged();
        }

        #region Search in Packet
        private int mISelection = 0;
        private List<int> mSelectionIndicis = null;
        private byte[] mSearchConvertedBytes;
        private string mValue_string = "";            

        private void btnSearchInPacket_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(tboxByteBuffer.Text))
                SearchBytesInBuffer(mValue_string);
        }

        private void tboxSearchValue_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxSearchValue.Text.Trim()))
            {
                mSelectionIndicis = null;
                tboxSearchConverted.Clear();
                lblSearchResult.Text = "0/0";
                return;
            }
            mValue_string = tboxSearchValue.Text.Trim();
            try
            {
                if (cboxSearchType.SelectedIndex == 0)   // Byte Array
                {
                    string[] a = mValue_string.Split(' ');
                    byte[] b = new byte[a.Length];
                    for (int i = 0; i < a.Length; i++)
                        b[i] = Convert.ToByte(a[i], 16);
                    mSearchConvertedBytes = b;
                    tboxSearchConverted.Text = "[" + mValue_string + "]";
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 1)  // String ASCII
                {
                    mSearchConvertedBytes = System.Text.Encoding.ASCII.GetBytes(mValue_string);
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 2)  // String UTF-8
                {
                    mSearchConvertedBytes = System.Text.Encoding.UTF8.GetBytes(mValue_string);
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 3)  // String Unicode
                {
                    mSearchConvertedBytes = System.Text.Encoding.Unicode.GetBytes(mValue_string);
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 4)  // Integer
                {
                    mSearchConvertedBytes = BitConverter.GetBytes(Convert.ToInt64(mValue_string));
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 5)  // Unsigned Integer
                {
                    mSearchConvertedBytes = BitConverter.GetBytes(Convert.ToUInt64(mValue_string));
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 6)  // Float
                {
                    mSearchConvertedBytes = BitConverter.GetBytes(Convert.ToSingle(mValue_string));
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
                else if (cboxSearchType.SelectedIndex == 7)  // Double
                {
                    mSearchConvertedBytes = BitConverter.GetBytes(Convert.ToDouble(mValue_string));
                    string s = ByteArrayToString(mSearchConvertedBytes);
                    tboxSearchConverted.Text = "[" + s + "]";
                    mValue_string = s;
                    //SearchBytesInBuffer(mValue_string);
                }
            }
            catch (Exception ex) { tboxSearchConverted.Clear(); }
        }

        private void SearchBytesInBuffer(string value_string)
        {
            mSelectionIndicis = GetIndicisOf(tboxByteBuffer.Text, value_string);
            if (mSelectionIndicis == null)
            {
                lblSearchResult.Text = "0/0";
            }
            else
            {
                mISelection = 0;
                SetSearchSelection();
            }
        }

        private void SetSearchSelection()
        {
            lblSearchResult.Text = (mISelection+1) + "/" + mSelectionIndicis.Count;
            tboxByteBuffer.SelectionStart = mSelectionIndicis[mISelection];
            tboxByteBuffer.SelectionLength = mValue_string.Length;
        }

        private List<int> GetIndicisOf(string toSearchIn, string toSearchFor)
        {
            int iEntry = toSearchIn.IndexOf(toSearchFor);
            if (iEntry < 0)
                return null;

            List<int> indicis = new List<int>();
            while (iEntry >= 0)
            {
                indicis.Add(iEntry);
                iEntry = toSearchIn.IndexOf(toSearchFor, iEntry + toSearchFor.Length);
            }
            return indicis;
        }

        private void btnSearchPrevious_Click(object sender, EventArgs e)
        {
            if (mSelectionIndicis == null) return;
            if (mISelection == 0)
                mISelection = mSelectionIndicis.Count - 1;
            else
                mISelection--;
            SetSearchSelection();
        }

        private void btnSearchNext_Click(object sender, EventArgs e)
        {
            if (mSelectionIndicis == null) return;
            if (mISelection < (mSelectionIndicis.Count - 1))
                mISelection++;
            else
                mISelection = 0;
            SetSearchSelection();
        }

        // Search Multiple packets
        private void btnSearchMultiplePackets_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            fbd1.Description = "Select a folder that contains packets from a game...";
            fbd1.SelectedPath = mOFDDir;
            if (fbd1.ShowDialog() == System.Windows.Forms.DialogResult.OK && !String.IsNullOrEmpty(fbd1.SelectedPath))
            {
                FolderBrowserDialog fbd2 = new FolderBrowserDialog();
                fbd2.Description = "Select a folder to drop the packets...";
                fbd2.SelectedPath = @"H:\";
                if (fbd2.ShowDialog() == System.Windows.Forms.DialogResult.OK && !String.IsNullOrEmpty(fbd2.SelectedPath))
                {
                    MessageBox.Show("HELLO");
                    string[] dirs = Directory.GetDirectories(fbd1.SelectedPath);
                    foreach (string dir in dirs)
                    {
                        string[] files = Directory.GetFiles(dir);
                        foreach(string file in files)
                        {
                            byte[] file_bytes = File.ReadAllBytes(file);
                            if (ContainsSequence(file_bytes, mSearchConvertedBytes))
                            {
                                string newDir = fbd2.SelectedPath + "\\" + new DirectoryInfo(dir).Name + "\\";
                                if (!Directory.Exists(newDir))
                                    Directory.CreateDirectory(newDir);
                                File.Copy(file, newDir + Path.GetFileName(file));
                            }
                        }
                    }
                }
            }
        }

        private bool ContainsSequence(byte[] toSearch, byte[] toFind)
        {
            for (var i = 0; i + toFind.Length < toSearch.Length; i++)
            {
                var allSame = true;
                for (var j = 0; j < toFind.Length; j++)
                {
                    if (toSearch[i + j] != toFind[j])
                    {
                        allSame = false;
                        break;
                    }
                }

                if (allSame)
                    return true;
            }
            return false;
        }
        #endregion

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            OnSelectionChanged();
        }

        #region Call of Duty: Modern Warfare 2
        private void btnPayloadToString_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = mOFDDir;
            fbd.Description = "Select a folder with folders (named like ip addresses) with packets...";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !String.IsNullOrEmpty(fbd.SelectedPath))
            {
                mOFDDir = fbd.SelectedPath;
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string dir in dirs)
                    PayloadToString(dir);
            }
        }

        private void PayloadToString(string path)
        {
            string[] packets = Directory.GetFiles(path);
            using (StreamWriter sw = new StreamWriter(path + "-Payloads_as_string.txt"))
            {
                foreach (string packet in packets)
                {
                    sw.WriteLine(packet);
                    byte[] bytes = File.ReadAllBytes(packet);
                    byte[] payload = bytes;
                    //byte[] payload = new byte[bytes.Length - 42];   //42 length Headers
                    //Buffer.BlockCopy(bytes, 42, payload, 0, payload.Length);
                    sw.WriteLine(System.Text.Encoding.UTF8.GetString(payload));
                    sw.WriteLine();
                }
            }
            using (StreamWriter sw = new StreamWriter(path + "-Payloads_as_string_w_byte[].txt"))
            {
                foreach (string packet in packets)
                {
                    sw.WriteLine(packet);
                    byte[] bytes = File.ReadAllBytes(packet);
                    byte[] payload = bytes;
                    //byte[] payload = new byte[bytes.Length - 42];   //42 length Headers
                    //Buffer.BlockCopy(bytes, 42, payload, 0, payload.Length);
                    string strBytes = "";
                    for (int i = 0; i < payload.Length; i++)
                    {
                        strBytes += payload[i].ToString("X2") + " ";
                        if ((i + 1) % 40 == 0)
                            strBytes += Environment.NewLine;
                    }
                    sw.WriteLine(strBytes);
                    sw.WriteLine(System.Text.Encoding.UTF8.GetString(payload));
                    sw.WriteLine();
                }
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            


            string output = mCurrentFileName + Environment.NewLine;
            int offset = 58;
            for (int i = 0; i < 5; i++)
                output += mBuffer[offset + i].ToString("X2") + " ";
            output += "- ";

            offset = 64;
            for (int i = 0; i < 33; i++)
                output += mBuffer[offset + i].ToString("X2") + " ";
            output += "- ";

            offset = 149;
            for (int i = 0; i < 9; i++)
                output += mBuffer[offset + i].ToString("X2") + " ";
            output += "- ";

            offset = 158;
            for (int i = 0; i < 14; i++)
                output += mBuffer[offset + i].ToString("X2") + " ";
            System.Windows.Forms.Clipboard.SetText(output);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(mOFDDir);

            int maxFileNameLength = 64;
            int maxIPLength = 21;


            string output = "##########################################################################################################################################################################################################" + Environment.NewLine +
                "##########################################################################################################################################################################################################" + Environment.NewLine;
            using (StreamWriter sw = new StreamWriter(@"H:\deleteme_packets\partystate header unknown bits v2 .txt", true))
            {
                sw.Write(output);
                output = "";
            }
            foreach (string f in files)
            {
                if (f.Substring(f.Length - 3, 3) == "txt" || f.Substring(f.Length - 3, 3) == "png")
                    break;
                string file = f;
                byte[] buffer = File.ReadAllBytes(file);
                //output += "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
                // get header ips
                string ipfrom = "From[" + (int)buffer[26] + "." + (int)buffer[27] + "." + (int)buffer[28] + "." + (int)buffer[29] + "]";
                string ipto = "- To[" + (int)buffer[30] + "." + (int)buffer[31] + "." + (int)buffer[32] + "." + (int)buffer[33] + "]";

                // make every filename the same length
                if (file.Length < maxFileNameLength)
                {
                    int limit = maxFileNameLength - file.Length;
                    for (int i = 0; i < limit; i++)
                        file += " ";
                }
                else if (file.Length > maxFileNameLength)
                {
                    file = file.Substring(0, maxFileNameLength);
                }
                // make ip addresses same length
                if (ipfrom.Length < maxIPLength)
                {
                    int limit = maxIPLength - ipfrom.Length;
                    for (int i = 0; i < limit; i++)
                        ipfrom += " ";
                }
                else if (ipfrom.Length > maxIPLength)
                {
                    ipfrom = ipfrom.Substring(0, maxIPLength);
                }
                if (ipto.Length < maxIPLength)
                {
                    int limit = maxIPLength - ipto.Length;
                    for (int i = 0; i < limit; i++)
                        ipto += " ";
                }
                else if (ipto.Length > maxIPLength)
                {
                    ipto = ipto.Substring(0, maxIPLength);
                }

                output += file + " " + ipfrom + " " + ipto + " <> ";
                int offset = 58;
                for (int i = 0; i < 5; i++)
                    output += buffer[offset + i].ToString("X2") + " ";
                output += "- ";

                if (buffer[62].ToString("X2").Substring(1, 1) == "9") // short package, print the rest
                {
                    output += ">> ";
                    for (int i = 64; i < buffer.Length; i++)
                        output += buffer[i].ToString("X2") + " ";
                }
                else
                {
                    offset = 64;
                    for (int i = 0; i < 33; i++)
                        output += buffer[offset + i].ToString("X2") + " ";
                    output += "- ";

                    offset = 149;
                    for (int i = 0; i < 9; i++)
                        output += buffer[offset + i].ToString("X2") + " ";
                    output += "- ";

                    offset = 158;
                    for (int i = 0; i < 14; i++)
                        output += buffer[offset + i].ToString("X2") + " ";
                }
                output += Environment.NewLine;

                using (StreamWriter sw = new StreamWriter(@"H:\deleteme_packets\partystate header unknown bits v2 .txt", true))
                {
                    sw.Write(output);
                    output = "";
                }
            }
            //output += Environment.NewLine + "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;
            //System.Windows.Forms.Clipboard.SetText(output);
            
            output = output;
        }

        

    }    
}
