using System;
using System.Windows.Forms;

namespace HubConnect
{
    // replace the current cursor with a 'busy' cursor
    // when this class is disposed of, restore the previous cursor
    public class WaitCursor : IDisposable
    {
        private readonly Cursor _previousCursor;

        public WaitCursor()
        {
            _previousCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            Cursor.Current = _previousCursor;
        }
    }
}