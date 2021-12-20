using DesignPattern.Creational.ComputerExample.Computer.MotherBoard.MainParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.ComputerExample.Computer.MotherBoard
{
    class MotherBoard
    {
        private CPU Cpu;
        private RAM Ram;
        private GPU Gpu;
        private Sockets sockets;
        private NetworkCard networkCard;
        private Disk disk;

        public MotherBoard(CPU cpu, RAM ram, GPU gpu, Sockets sockets, NetworkCard networkCard, Disk disk)
        {
            Cpu = cpu;
            Ram = ram;
            Gpu = gpu;
            this.sockets = sockets;
            this.networkCard = networkCard;
            this.disk = disk;
        }
        public CPU GetCPU() => Cpu;
        public RAM GetRAM() => Ram;
        public GPU GetGPU() => Gpu ;
        public MainParts.Sockets GetSockets() => sockets ;
        public NetworkCard  GetNetworkCard() => networkCard ;
        public Disk GetDisk() => disk;
    }
}
