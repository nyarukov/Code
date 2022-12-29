#include "stm32f10x.h"                  // Device header
#include "Delay.h"
// #include "bsp_exti.h"
#include "bsp_led.h"
#include "bsp_systick.h"


int main(void)
{
	LED_INIT();
	#if 0
        OLED_Init();
		EXIT_Config();
        OLED_ShowString(1,6,"ANum");
        OLED_ShowString(2,6,"BNum");
    #endif
	while(1){
		LED_ON(GPIO_Pin_11);
		SysTick_Delay_ms(500);
		LED_OFF(GPIO_Pin_11);
		SysTick_Delay_ms(500);
		
	}
	

}
