if __name__ == '__main__':
    n = int(input())
    arr = []
    
    for x in range(n):
        com = (input().split())
        if com[0] == "insert":
            arr.insert(int(com[1]),int(com[2]))
        elif com[0] == "remove":
            arr.remove(int(com[1]))
        elif com[0] == "append":
            arr.append(int(com[1]))
        elif com[0] == "sort":
            arr.sort()
        elif com[0] == "pop":
            arr.pop()
        elif com[0] == "reverse":
            arr.reverse()
        elif com[0] == "print":
            print (arr)