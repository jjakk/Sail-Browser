
import time

for x in range(0, 100):

    r = open("useless.txt", "a")

    r.write(str(x));

    r.close();

    time.sleep(1)
