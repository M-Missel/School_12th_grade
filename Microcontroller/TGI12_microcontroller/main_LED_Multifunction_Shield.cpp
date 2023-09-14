#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
// Blinking rate in milliseconds
#define BLINKING_RATE       500ms
#define sleep               ThisThread::sleep_for

int main()
{
    // Initialise the digital pin LED1 as an output
    DigitalOut led1(LED1);
    DigitalOut led2(LED2);
    DigitalOut led3(LED3);
    DigitalOut led4(LED4);
    // Initialise the digital pin LED1 as an output
    //DigitalOut led(LED1);
    BufferedSerial serial_port(USBTX, USBRX);

    char c;

    while (1) {
        if(serial_port.readable()){
            serial_port.read(&c, 1);
        }

        switch (c) {
            case 'A': led1 = 1; break;
            case 'B': led2 = 1; break;
            case 'C': led3 = 1; break;
            case 'D': led4 = 1; break;
            case 'a': led1 = 0; break;
            case 'b': led2 = 0; break;
            case 'c': led3 = 0; break;
            case 'd': led4 = 0; break;
        }
    }
}

#endif