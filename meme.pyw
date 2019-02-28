
import time

for x in range(0, 1000):

    r = open("useless.txt", "a")

    r.write(str(x));

    r.close();

    time.sleep(2)
