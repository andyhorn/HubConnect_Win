using System;
using InTheHand.Net;

namespace HubConnect
{
    public static class Obex
    {
        public static ObexStatusCode SendFile(BluetoothAddress address, string data)
        {
            // create a temporary file in the local directory containing the data to send
            const string path = "./temp.txt";
            // write the data to the file
            System.IO.File.WriteAllText(path, data);

            // generate the OBEX path to send the file to
            var urlString = $"obex://{address.ToString()}/{path}";
            var uri = new Uri(urlString);

            // create the OBEX request object
            var request = new ObexWebRequest(uri);

            // read the file into the request
            request.ReadFile(path);

            try
            {
                // send the file and retrieve the response
                var response = (ObexWebResponse)request.GetResponse();
                
                // close the connection
                response.Close();

                // delete the temporary file
                System.IO.File.Delete(path);

                // return the response code
                return response.StatusCode;
            }
            catch (Exception e)
            {
                // if there was an exception, clean up the temporary file
                System.IO.File.Delete(path);

                // return an error code
                return ObexStatusCode.InternalServerError;
            }
        }
    }
}