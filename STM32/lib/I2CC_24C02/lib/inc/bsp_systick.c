#include "bsp_systick.h"


void SysTick_Delay_us(uint32_t us){
    SysTick_Config(72);
    uint32_t i;
    for (i=0; i < us; i++)
    {
        while(!((SysTick->CTRL)&(1<<16)));
    }
    SysTick->CTRL &= ~(SysTick_CTRL_ENABLE_Msk);
}

void SysTick_Delay_ms(uint32_t ms){
    SysTick_Config(72000);
    uint32_t i;
    for ( i = 0; i < ms; i++)
    {
        while(!((SysTick->CTRL)&(1<<16)));
    }
    SysTick->CTRL &=~(SysTick_CTRL_ENABLE_Msk);
}