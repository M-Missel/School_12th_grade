#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"

// Blinking rate in milliseconds
#define BLINKING_RATE     3000ms
#define BLINKING_TRUE     true
#define sleep             ThisThread::sleep_for

int main()
{
    BufferedSerial pc(USBTX, USBRX);
    DigitalOut led1(LED1);

    char buffer[1] = {0};
    pc.set_baud(9600);
    pc.set_format(8,BufferedSerial::None, 1);

    while(true){
        if(pc.readable()){
            pc.read(buffer, 1);

            pc.write(buffer, 1);

            led1 != led1;
        }
    }
}
#endif