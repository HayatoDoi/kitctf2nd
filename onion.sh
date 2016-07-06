#!/bin/sh
s="flag"
d=".zip"
for i in `seq 0 998`
do
	tmp=`expr 999 - $i`
	unzip $s$tmp$d
done
