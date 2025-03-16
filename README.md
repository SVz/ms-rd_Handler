
# Project Title

Windows Tailscale URI Handler


## Features

Open RDP URI used by Tailscale with Windows client.


## Usage/Examples

URI form : ms-rd:subscribe?url=x.x.x.x


## Installation

Add Registry Entry like this :

Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\ms-rd]\
@="URL:Remote Desktop Protocol"\
"URL Protocol"=""

[HKEY_CLASSES_ROOT\ms-rd\shell]

[HKEY_CLASSES_ROOT\ms-rd\shell\open]

[HKEY_CLASSES_ROOT\ms-rd\shell\open\command]\
@="\"C:\\Users\\SVz\\source\\repos\\ms-rd_Handler\\ms-rd_Handler\\bin\\Release\\ms-rd_Handler.exe\" \"%1\""    
