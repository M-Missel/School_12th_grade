#if 1
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>
// Blinking rate in milliseconds

DigitalOut led(LED1);

void on_off(int32_t time);

int main()
{
    // Initialise the digital pin LED1 as an output
    //DigitalOut led(LED1);
    BufferedSerial serial_port(USBTX, USBRX);

    char c;

    while (1) {
        if(serial_port.readable()){
            serial_port.read(&c, 1);
        }

        BLINKING_ON;

        switch (c) {
            case '1': on_off(2000); break;
            case '2': on_off(1000); break;
            case '3': on_off(500); break;
            case '4': on_off(200); break;
            case '5': on_off(100); break;
        }
    }
}

void on_off(int32_t time){
    BLINKING_ON;
    sleep(time);
    BLINKING_OFF;
    sleep(time);
}

#endif