﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnifferApp.Logic.UI
{
    /// <summary>
    /// Interaction logic for PacketLine.xaml
    /// </summary>
    public partial class PacketLine : UserControl
    {
        public Packet packet;

        private PacketLine()
        {
            InitializeComponent();
        }

        public PacketLine(Packet p) : this()
        {
            packet = p;
            PacketDirection.Content = p.s2c ? p.broadcast ? "S2A" : "S2C" : "C2S";
            Timestamp.Content = p.ReceivedTime.ToString("H:mm:ss.ffff");
            Name.Content = p.Name;
            Background = p.s2c ? p.broadcast ? Brushes.BlueViolet : Brushes.MediumBlue : Brushes.PaleVioletRed;
        }
    }
}
