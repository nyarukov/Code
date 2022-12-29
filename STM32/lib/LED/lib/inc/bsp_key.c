#include "bsp_key.h"

void KEY_INIT(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    RCC_APB2PeriphClockCmd(KEY_APB2ENR , ENABLE);
    GPIO_InitStruct.GPIO_Mode = KEY_Mode;
    GPIO_InitStruct.GPIO_Pin = KEY_Pin;
    GPIO_Init(KEY_Port_GPIO, &GPIO_InitStruct);
}

uint8_t KEY_GET(void){
    uint8_t KEYNUM=0;
    if((GPIO_ReadInputDataBit(KEY_Port_GPIO,KEY_Pin))==RESET)
    {
        Delay_ms(50);
        while ((GPIO_ReadInputDataBit(KEY_Port_GPIO,KEY_Pin))==RESET);
        Delay_ms(20);
        KEYNUM=SET;
    }
    return KEYNUM;
}

