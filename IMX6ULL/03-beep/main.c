#include "include/imx6ull.h"

void CCM_Config(void){
    CCM->CCGR1=0XFFFFFFFF;
    CCM->CCGR2=0XFFFFFFFF;
    CCM->CCGR3=0XFFFFFFFF;
    CCM->CCGR4=0XFFFFFFFF;
    CCM->CCGR5=0XFFFFFFFF;
    CCM->CCGR6=0XFFFFFFFF;
}

void GPIO_Config(void){
    IOMUXC_SNVS->MUX_CTL_PAD_SNVS_TAMPER1=5;
    IOMUXC_SNVS->PAD_CTL_PAD_SNVS_TAMPER1=0X10B0;
    GPIO5->GDIR =2;
    GPIO5->DR = 0;
}

int main(void){
    CCM_Config();
    GPIO_Config();
    while(1);
    return 0;
}
