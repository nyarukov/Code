/*
 * @Author: error: git config user.name && git config user.email & please set dead value or install git
 * @Date: 2022-11-04 20:11:19
 * @LastEditors: error: git config user.name && git config user.email & please set dead value or install git
 * @LastEditTime: 2022-11-04 20:32:37
 * @FilePath: \LED\System\bsp_led.c
 * @Description: 这是默认设置,请设置`customMade`, 打开koroFileHeader查看配置 进行设置: https://github.com/OBKoro1/koro1FileHeader/wiki/%E9%85%8D%E7%BD%AE
 */
#include "bsp_led.h"

void LED_Config(void)
{
    GPIO_InitTypeDef GPIO_InitStruct;
    DEBUG_LED_CLK(DEBUG_LED_PCK,ENABLE);
    GPIO_InitStruct.GPIO_Pin=DEBUG_LED_PIN;
    GPIO_InitStruct.GPIO_Mode=DEBUG_LED_MODE;
    GPIO_InitStruct.GPIO_Speed=DEBUG_LED_SPEED;
    GPIO_Init(DEBUG_LED_PROT,&GPIO_InitStruct);
    GPIO_SetBits(DEBUG_LED_PROT,DEBUG_LED_PIN);
}
void LED_ON(uint16_t GPIO_Pin)
{
    GPIO_ResetBits(DEBUG_LED_PROT,GPIO_Pin);
}
void LED_OFF(uint16_t GPIO_Pin)
{
    GPIO_SetBits(DEBUG_LED_PROT,GPIO_Pin);
}
void LED_Reverse(uint16_t GPIO_Pin)
{
    if(GPIO_ReadOutputDataBit(DEBUG_LED_PROT,GPIO_Pin)==RESET)
    {
         GPIO_SetBits(DEBUG_LED_PROT,GPIO_Pin);
    }
    else
    {
        GPIO_ResetBits(DEBUG_LED_PROT,GPIO_Pin);
    }
}
