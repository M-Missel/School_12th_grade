#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

int main()
{
    DigitalOut led(LED1);
    BufferedSerial serial_port(USBTX, USBRX);
    char c;

    while (1) {
        if(serial_port.readable()){
            serial_port.read(&c, 1);
            led = !led;
            serial_port.write(&c, 1);
        }
    }
}

#endif