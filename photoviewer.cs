using System;
using System.Diagnostics;

namespace PhotoViewerLaunch
{
  class Program
  {
    static void Main(string[] args)
    {
      Process.Start(new ProcessStartInfo
          {
          UseShellExecute = true,
          FileName = "C:\\Windows\\System32\\rundll32.exe",
          Arguments = "\"C:\\Program Files\\Windows Photo Viewer\\PhotoViewer.dll\", ImageView_Fullscreen",
          });
    }
  }
}
