#include "stm32f10x.h"
#include "delay.h"
#include "bsp_led.h"
// #include "bsp_key.h"
#include "bsp_exti.h"

#define SET     1
#define RESET   0


// void EXTI0_IRQHandler(void){
//     if(EXTI_GetITStatus(EXTI_Line0)!=RESET)
//     {
//         LED_ON();
//         EXTI_ClearITPendingBit(EXTI_Line0);
//     }
    
// }

int main(void)
{
  
    GPIO_InitTypeDef GPIO_InitStruct;
    RCC_APB2PeriphClockCmd(RCC_APB2Periph_GPIOA, ENABLE);
    
    GPIO_InitStruct.GPIO_Mode = GPIO_Mode_IPU;
    GPIO_InitStruct.GPIO_Pin = GPIO_Pin_0;
    GPIO_InitStruct.GPIO_Speed=GPIO_Speed_50MHz;
    GPIO_Init(RCC_APB2Periph_GPIOA, &GPIO_InitStruct);

    LED_INIT();
    //  KEY_INIT();
    EXIT_Config();

    while (1)
    {
        #if 1
        LED_ON();
        Delay_ms(100);
        LED_OFF();
        Delay_ms(100);
        
        #endif 
       
    }
    
}
