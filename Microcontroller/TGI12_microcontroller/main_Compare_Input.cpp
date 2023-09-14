#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
// Blinking rate in milliseconds
#define BLINKING_RATE       500ms
#define BLINKING_ON         led = 1
#define BLINKING_OFF        led = 0
#define sleep               ThisThread::sleep_for

int main()
{
    // Initialise the digital pin LED1 as an output
    DigitalOut led(LED1);
    BufferedSerial serial_port(USBTX, USBRX);
    char c;
    int i = 0;

    while (1) {
        if(serial_port.readable()){
            serial_port.read(&c, 1);
            i = c;
        }

        /* Task A
        if(i == 65 || i == 97){
            printf("Auswahl A \n");
        }else if (i == 66 || i == 98) {
            printf("Auswahl B \n");
        }else if (i == 67 || i == 99) {
            printf("Auswahl C \n");
        }else if (i == 68 || i == 100) {
            printf("Auswahl D \n");
        }
        */

        // Task B

        switch (i) {
            case 65:
            case 97: printf("Auswahl A \n"); break;

            case 66:
            case 98: printf("Auswahl B \n"); break;

            case 67:
            case 99: printf("Auswahl C \n"); break;

            case 68:
            case 100: printf("Auswahl D \n"); break;
        }
        i = 0;
        c = ' ';
    }
}

#endif