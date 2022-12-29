#ifndef __GPIO_H
#define __GPIO_H

#include "imx6ull.h"

typedef struct 
{
    _IO DR;
    _IO GDIR;
    _IO PSR;
    _IO ICR1;
    _IO ICR2;
    _IO IMR;
    _IO ISR;
    _IO EDGE_SEL;
}GPIOX_Type;

#define GPIO1   ((GPIOX_Type*)GPIO1_BASE)
#define GPIO2   ((GPIOX_Type*)GPIO2_BASE)
#define GPIO3   ((GPIOX_Type*)GPIO3_BASE)
#define GPIO4   ((GPIOX_Type*)GPIO4_BASE)
#define GPIO5   ((GPIOX_Type*)GPIO5_BASE)

#endif // !__GPIO_H