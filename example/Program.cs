using System;
using Apache.Hadoop.Hive;
using Thrift.Protocol;
using Thrift.Transport;


namespace Hive.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 10111;

            var socket = new TSocket("ca1.newco.com", port);
            var transport = new TBufferedTransport(socket);
            var proto = new TBinaryProtocol(transport);
            var client = new ThriftHive.Client(proto);

            transport.Open();
            client.execute("select userAgent from clicks limit 100");
            var rows = client.fetchAll();
            transport.Close();

            rows.ForEach(Console.WriteLine);
        }
    }
}
