﻿using System;
using System.ServiceModel;
using TcpBinding.Contracts;

namespace TcpBinding.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var uris = new Uri[1];
            string addr = "net.tcp://localhost:4345/ProductService";
            uris[0] = new Uri(addr);
            IProductService productService = new ProductService();
            ServiceHost host = new ServiceHost(productService,uris);
            var binding = new NetTcpBinding(SecurityMode.None);
            host.AddServiceEndpoint(typeof(IProductService), binding,"");
            host.Opened += HostOnOpened;
            host.Open();
            Console.ReadLine();
        }

        private static void HostOnOpened(object sender, EventArgs e)
        {
            Console.WriteLine("WCF service is started");
        }
    }
}
