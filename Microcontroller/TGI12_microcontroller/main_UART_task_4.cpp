#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */
#include "mbed.h"
#include <string>
#include <cstdlib>

// Blinking rate in milliseconds
#define BLINKING_RATE 3000ms
#define BLINKING_TRUE true
#define sleep ThisThread::sleep_for

BufferedSerial pc(USBTX, USBRX, 9600);
BufferedSerial blue(PB_10, PB_11, 9600);
DigitalOut enable(PB_12,1);
PwmOut led1(PC_6);

void initSerial(){
    pc.set_format(8, BufferedSerial::None, 1);

    blue.set_format(8, BufferedSerial::None, 1);
}

int main() {
    char buffer[40] = {0};
    string cmd = "";

    initSerial();

    while (true) {
        if(blue.readable()){
            int num = blue.read(buffer, sizeof(buffer));
            cmd = buffer;
            led1.write(atof(cmd.c_str()));
        }
        memset(buffer, 0, sizeof(buffer));

        cmd = "";
        sleep(500);
    }
}
#endif