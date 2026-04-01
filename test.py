def snt(n):
    if n <= 1:
        return False
    for i in range(2,n-1):
        if n % i == 0:
            return False
    return True
def ktra(arr):
    ds=[]
    for i in arr:
        if snt(i) == True:
            ds.append(i)
    print(ds)
ktra([1,2,3,4,5,6,7,8,9,10,11,12,13])