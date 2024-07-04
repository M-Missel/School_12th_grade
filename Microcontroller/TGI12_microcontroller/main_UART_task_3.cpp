#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */
#include "mbed.h"
#include <string>

// Blinking rate in milliseconds
#define BLINKING_RATE 3000ms
#define BLINKING_TRUE true
#define sleep ThisThread::sleep_for

BufferedSerial pc(USBTX, USBRX, 9600);
BufferedSerial blue(PB_10, PB_11, 9600);
DigitalOut enable(PB_12,1);
DigitalOut led1(LED1,1);

void initSerial(){
    pc.set_format(8, BufferedSerial::None, 1);

    blue.set_format(8, BufferedSerial::None, 1);
}

int main() {
    char buffer[20] = {0};
    
    string cmd = "";

    while (true) {

        if(blue.readable()){
            int num = blue.read(buffer, sizeof(buffer));
            cmd = buffer;

            if(cmd == "on")
                led1.write(1);
            else if (cmd == "off")
                led1.write(0);
            
            pc.write(buffer, num);
            memset(buffer, 0, sizeof(buffer));
        }
        cmd = "";

        sleep(500);
    }
}
#endif