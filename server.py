import os, socket, time
from datetime import datetime
#from json2html import *
HOST = 'tux.cs.ccu.edu.tw'
#HOST = '127.0.0.1'
PORT = 8089
WEB_PATH = os.path.expanduser('~')+"/WWW/index.html"
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen(10)
clientMessage = ""
toilet_flag = False
data_collect={"right":{"cnt":0, "timestamp":0}, "left":{"cnt":0, "timestamp":0}, "toilet":{"cnt":0, "timestamp":0}}
warning = ""
while True:
    conn, addr = server.accept()
    try:
        clientMessage = str(conn.recv(1024), encoding='utf-8').strip()
    except:
        pass
    ts = time.time()
    print('Receive: ', clientMessage, datetime.fromtimestamp(ts))
    if 'right' in clientMessage:
        data_collect["right"]["cnt"]=data_collect["right"]["cnt"]+1
        data_collect["right"]["timestamp"] = ts
    elif 'left' in clientMessage:
        data_collect["left"]["cnt"]=data_collect["left"]["cnt"]+1
        data_collect["left"]["timestamp"] = ts
    elif 'toilet' in clientMessage:
        data_collect["toilet"]["cnt"]=data_collect["toilet"]["cnt"]+1
        data_collect["toilet"]["timestamp"] = ts
        if toilet_flag == False:
            toilet_flag = True
        else:
            toilet_flag = False
            warning = ""
    else:
        pass

    if toilet_flag == True:
        period = time.time() - data_collect["toilet"]["timestamp"]
        print("%.2f" %period)
        if period > 1 * 60:
            warning = "[warning!!]"
    serverMessage = 'ack'
    conn.sendall(serverMessage.encode())
    conn.close()
    #htmlText = json2html(data_collect)

    toilet_status = "(free)"
    if toilet_flag == True:
        toilet_status = "(in use, "+str(period).split(".")[0]+" secs)"+warning

    htmlText = "<table border=\"1\"><tr><th>right</th><td>"+str(data_collect['right']["cnt"])+"</td></tr><tr><th>left</th><td>"+str(data_collect['left']["cnt"])+"</td></tr><tr><th>toilet</th><td>"+str(data_collect['toilet']["cnt"])+toilet_status+"</td></tr></table>"
    f = open(WEB_PATH, 'w')
    f.write(htmlText)
    f.close()

