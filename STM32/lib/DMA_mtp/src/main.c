#include "stm32f10x.h"
#include "bsp_led.h"
#include "delay.h"
#include "bps_dma_mtp.h"

extern uint8_t Buffer[BUFFER_SIZE];

int main()
{
    uint8_t i;

    LED_Config();
    USART_Config();
    USART_MTP_Config();
    LED_ON(GPIO_Pin_11);
    for ( i = 0; i < BUFFER_SIZE; i++)
    {
       Buffer[i]='A';
    }
    USART_DMACmd(USART1,USART_DMAReq_Tx,ENABLE);

    while (1)
    {
        LED_TURN(GPIO_Pin_1);
        Delay_ms(100);
        
    }
}