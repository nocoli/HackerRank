if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
    
    # turn the map into a list
    result = list(arr)
    
    # sort the list
    result.sort()
    
    # get the value of the highest int in the list
    maxVal = (max(result))
    
    # reverse the list
    result.reverse()
    
    # while the first value is equal to the highest
    # value, delete the first value until the first
    # value becomes the second highest int
    while (result[0] == maxVal):
        result.remove(maxVal)
            
    # print second highest value
    print (max(result))
    
    
