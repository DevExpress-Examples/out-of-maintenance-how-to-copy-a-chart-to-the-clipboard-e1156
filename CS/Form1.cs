using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;
// ...

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MemoryStream ms = new MemoryStream();
            try {
                chartControl1.ExportToImage(ms, ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);

                Bitmap mf = new Bitmap(ms);
                Clipboard.SetImage(mf);
            }
            finally {
                ms.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            MemoryStream ms = new MemoryStream();
            try {
                chartControl1.ExportToImage(ms, ImageFormat.Emf);
                ms.Seek(0, SeekOrigin.Begin);

                Metafile mf = new Metafile(ms);
                ClipboardMetafileHelper.PutEnhMetafileOnClipboard(this.Handle, mf );
            }
            finally {
                ms.Close();
            }
        }
    }

    #region ClipboardMetafileHelper
    public class ClipboardMetafileHelper {
        [DllImport("user32.dll")]
        static extern bool OpenClipboard(IntPtr hWndNewOwner);
        [DllImport("user32.dll")]
        static extern bool EmptyClipboard();
        [DllImport("user32.dll")]
        static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);
        [DllImport("user32.dll")]
        static extern bool CloseClipboard();
        [DllImport("gdi32.dll")]
        static extern IntPtr CopyEnhMetaFile(IntPtr hemfSrc, IntPtr hNULL);
        [DllImport("gdi32.dll")]
        static extern bool DeleteEnhMetaFile(IntPtr hemf);

        // Metafile mf is set to a state that is not valid inside this function.
        static public bool PutEnhMetafileOnClipboard(IntPtr hWnd, Metafile mf) {
            bool bResult = false;
            IntPtr hEMF, hEMF2;
            hEMF = mf.GetHenhmetafile(); // invalidates mf
            if (!hEMF.Equals(new IntPtr(0))) {
                hEMF2 = CopyEnhMetaFile(hEMF, new IntPtr(0));
                if (!hEMF2.Equals(new IntPtr(0))) {
                    if (OpenClipboard(hWnd)) {
                        if (EmptyClipboard()) {
                            IntPtr hRes = SetClipboardData(14 /*CF_ENHMETAFILE*/, hEMF2);
                            bResult = hRes.Equals(hEMF2);
                            CloseClipboard();
                        }
                    }
                }
                DeleteEnhMetaFile(hEMF);
            }
            return bResult;
        }
    }
    #endregion

}