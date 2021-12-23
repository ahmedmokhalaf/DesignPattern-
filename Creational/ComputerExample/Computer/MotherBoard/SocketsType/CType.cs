namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard.SocketsType
{
    class CType
    {
        private bool WithVideoTransfer;

        public CType(bool withVideoTransfer)
        {
            WithVideoTransfer = withVideoTransfer;
        }

        public bool GetWithVideoTransfer() => WithVideoTransfer;
    }
}
