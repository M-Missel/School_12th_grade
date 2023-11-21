#if 0
/* mbed Microcontroller Library
 * Copyright (c) 2019 ARM Limited
 * SPDX-License-Identifier: Apache-2.0
 */

#include "mbed.h"
#include <cstdint>
#define MASKMATRIX      0xF000
#define MASK7SEG        0xFF

const uint8_t seg7code[]{
    //DEFINED
};
uint8_t spaltenCode = 0, arrayIndex = 0;

DigitalOut seg7Display_Ones_on_off(PC_12, 0);
DigitalOut seg7Display_Tens_on_off(PC_11, 1);
DigitalOut activateMatrix(PA_8, 1);
PortOut seg7Display(PortC, MASK7SEG);
PortIn matrix(PortB, MASKMATRIX);

int main()
{
    matrix.mode(PullUp);

    while (1) {
        activateMatrix.write(0);
        
        sleep(10);

        spaltenCode = matrix.read() >> 12;

        sleep(10);

        activateMatrix.write(1);

        switch (spaltenCode) {
            case 7:
                seg7Display_Ones_on_off.write(1);
                seg7Display_Tens_on_off.write(0);
                seg7Display.write(seg7code[1]);
                break;
            case 11:
                seg7Display_Ones_on_off.write(1);
                seg7Display_Tens_on_off.write(0);
                seg7Display.write(seg7code[2]);
                break;
            case 13:
                seg7Display_Ones_on_off.write(1);
                seg7Display_Tens_on_off.write(0);
                seg7Display.write(seg7code[3]);
                break;
            case 14:
                seg7Display_Ones_on_off.write(1);
                seg7Display_Tens_on_off.write(0);
                seg7Display.write(seg7code[10]);
                break;
            default:
                seg7Display_Ones_on_off.write(0);
                seg7Display_Tens_on_off.write(1);
                seg7Display.write(0);
                break;
        }

        sleep(500);
    }
}

#endif