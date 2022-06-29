using System;

using WebSocketSharp;
using WebAPI2;

string user_name = "HRVYSTLD3";
string password = "1Password!";
string client_app_id = "HRVYSTWAPI";
string client_version = "python-client-test-2-1";

string base_time = "";
string startDate = "2022-06-17T00:00:00";
string endDate = "2022-06-24T00:00:00";
string host_name = "wss://demoapi.cqg.com:443";



WebSocket ws = new(host_name);

ws.Connect();

string baseTime = LogOn(user_name, password, client_app_id, client_version);



/*
    client = webapi_client.WebApiClient()
    client.connect(host_name)
    base_time = logon(user_name, password)    
    t1 = Thread(target = filter_order())
    t1.daemon = True
    t1.start()
*/





string LogOn(string user_name,string password,
         string client_app_id,string client_version,
         uint protocol_version_major= 2,uint protocol_version_minor = 1)
{
    var client_msg = new ClientMsg();
    var logon = client_msg.Logon;
    logon.UserName = user_name;
    logon.Password = password;
    logon.ClientAppId = client_app_id;
    logon.ClientVersion = client_version;
    logon.ProtocolVersionMajor = protocol_version_major;
    logon.ProtocolVersionMinor = protocol_version_minor;
    logon.PrivateLabel = "HRVYST";
    send_client_message(client_msg);
    ServerMsg ServerMsg = ReciveServerMsg();
    if (ServerMsg.LogonResult.ResultCode != 0)
    {
        Exception("Can't Login" + ServerMsg.LogonResult.TextMessage);
        return "";
    }
    else
    {
        return ServerMsg.LogonResult.BaseTime;
    }
}

void  send_client_message(ClientMsg client_msg)
{
    ws.Send(client_msg.ToString());
    Console.Write("Client message sent:\n" + client_msg.ToString());
}



/*
 
    def send_client_message(self, client_msg):
        self._connection.send(client_msg.SerializeToString(), websocket.ABNF.OPCODE_BINARY)
        if self._need_to_log:
            print("Client message sent:\n" + str(client_msg))


 */


ServerMsg ReciveServerMsg()
{
    var server_msg = new ServerMsg();
    return server_msg;
}



/*
def receive_server_message(self):
        server_msg = ServerMsg()
        opcode, data = self._connection.recv_data()
        if opcode == websocket.ABNF.OPCODE_TEXT:
            raise Exception("Received unexpected text message from WebAPI server")
        elif opcode == websocket.ABNF.OPCODE_CLOSE:
            raise websocket.WebSocketConnectionClosedException(
                "Can't receive message - WebAPI server closed connection")

        server_msg.ParseFromString(data)

        if self._need_to_log:
            print("Server message received:\n" + str(server_msg))
        return server_msg
*/

void Exception(string v)
{
    throw new System.Exception(v);
}