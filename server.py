import socket
#from json2html import *
HOST = 'tux.cs.ccu.edu.tw'
#HOST = '127.0.0.1'
PORT = 8089
WEB_PATH = "/.CSDATA_NFS/home/master/ms100/tsm100m/WWW/index.html"
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen(10)
clientMessage = ""
data_collect={"right":0, "left":0, "toilet":0}
while True:
    conn, addr = server.accept()
    try:
        clientMessage = str(conn.recv(1024), encoding='utf-8').strip()
    except:
        pass
    print('Receive: ', clientMessage)
    if clientMessage == 'right':
        data_collect["right"]=data_collect["right"]+1
    elif clientMessage == 'left':
        data_collect["left"]=data_collect["left"]+1
    elif clientMessage == 'toilet':
        data_collect["toilet"]=data_collect["toilet"]+1
    else:
        pass

    serverMessage = 'ack'
    conn.sendall(serverMessage.encode())
    conn.close()
    #htmlText = json2html(data_collect)
    htmlText = "<table border=\"1\"><tr><th>right</th><td>"+str(data_collect['right'])+"</td></tr><tr><th>left</th><td>"+str(data_collect['left'])+"</td></tr><tr><th>toilet</th><td>"+str(data_collect['toilet'])+"</td></tr></table>"
    f = open(WEB_PATH, 'w')
    f.write(htmlText)
    f.close()

