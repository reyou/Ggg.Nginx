 #!/bin/bash
apt-cache search nginx | grep ^nginx | awk ' { print $1 } '