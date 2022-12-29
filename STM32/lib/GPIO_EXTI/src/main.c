#include "stm32f10x.h"                  // Device header
#include "Delay.h"
#include "bsp_exti.h"
#include "bsp_led.h"

uint32_t ANum=0;
uint32_t BNum=0;

void EXTI0_IRQHandler(void){
    
    if(EXTI_GetITStatus(EXTI_Line0)==SET)
    {
        if(GPIOA->IDR==0x01)
        {
            ANum++;
            #if 0
            OLED_ShowNum(1, 7, ANum, 5);
            #endif
        }
         if(GPIOB->IDR==0x01)
        {
            BNum++;
            #if 0
            OLED_ShowNum(2, 7, BNum, 5);
            #endif
        }
    }
    EXTI_ClearITPendingBit(EXTI_Line0);
}


int main(void)
{
	// LED_INIT();
	#if 0
        OLED_Init();
        OLED_ShowString(1,6,"ANum");
        OLED_ShowString(2,6,"BNum");
    #endif
	EXIT_Config();
	while(1){
        
		// LED_ON(GPIO_Pin_11);
		// Delay_ms(1000);
		// LED_OFF(GPIO_Pin_11);
		// Delay_ms(1000);
	}
	

}
