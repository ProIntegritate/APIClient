import base64
import re
import sys
import os

#clear console
os.system('clear')
sConsole = ''

try: {
        #may not exist
        sConsole := sys.argv[1]
}
except: {
        #errorhandling
}

#For testing
if (sConsole == ""):
        sConsole = 'Q0xJRU5USVA6MTI3LjAuMC4xOjYzMTYyDQpmb28gCg=='

bConsole = base64.b64decode(sConsole)
sInput =  bConsole.decode("utf-8")

print ("Input was = " + sInput)
sInput = re.sub("CLIENT.*\s", "", sInput)
print ("Input became = " + sInput)


