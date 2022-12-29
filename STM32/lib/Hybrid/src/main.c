#include "stm32f10x.h"
#include "bsp_led.h"
#include "delay.h"

int main()
{
    LED_Config();
    while (1)
    {
        LED_ON(GPIO_Pin_1);
        Delay_ms(100);
        LED_OFF(GPIO_Pin_1);
        Delay_ms(100);
    }
}