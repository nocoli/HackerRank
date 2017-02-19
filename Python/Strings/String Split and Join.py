def split_and_join(line):
    # write your code here
    listA = []
    listA = line.split(" ")
    answer = "-".join(listA)
    return answer
	
if __name__ == '__main__':
    line = input()
    result = split_and_join(line)
    print(result)