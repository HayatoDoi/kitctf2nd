qes = '4423244324433534315412244543132315132515421234114214'

polybious = [['a','b','c','d','e'],
			['f','g','h','i','k'],
			['l','m','n','o','p'],
			['q','r','s','t','u'],
			['v','w','x','y','z']]
ans = ''

while len(qes)!=0:
  ans += polybious[int(qes[0])-1][int(qes[1])-1]
  qes = qes[2:]
print 'kitctf{'+ans+'}'
