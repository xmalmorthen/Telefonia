#!/bin/bash
`chat -Vs TIMEOUT 3 "" "ATZ" "OK" > /dev/ttyUSB0 < /dev/ttyUSB0`
`chat -Vs TIMEOUT 3 "" "AT+CMGD=$1" "OK" > /dev/ttyUSB0 < /dev/ttyUSB0`
`chat -Vs TIMEOUT 3 "" "ATZ" "OK" > /dev/ttyUSB0 < /dev/ttyUSB0`