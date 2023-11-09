@echo off
title EXERCICIO - NUMEROS ALEATORIOS
mode 60,30
color 0a
:sorteio
set /a numero=(%random% %%50) + 1
set /a cont=5
:inicio
cls
echo.
echo.
echo                 (o o)
echo ============ooO==(_)==Ooo===============
echo ADVINHE O NUMERO SORTEADO ENTRE 01 E 50 
echo ----------------------------------------
echo    QUANTIDADE DE TENTATIVAS:  %cont% 
echo ----------------------------------------
echo ========================================
echo.
set /p palpite=DIGITE O SEU PALPITE:

if %palpite% gtr 50 (
    echo.
    echo ----------------------------------------
    echo     Digite Numeros entre 01 e 50 !!!
    echo ----------------------------------------
    pause > nul
    goto:inicio)

if %palpite% lss 1 (
    echo.
   echo ----------------------------------------
   echo     Digite Numeros entre 01 e 50 !!!
   echo ----------------------------------------
   pause > nul
   goto:inicio)

if %cont% == 0 (
   echo.
   echo ----------------------------------------
   echo               Vc perdeu!!! 
   echo      O numero sorteado era: %numero%
   echo ----------------------------------------
   pause > nul 
   goto:sair )
   
if %palpite% == %numero% (
   echo.
   echo ----------------------------------------
   echo         Parabens vc ganhou !!! 
   echo      O numero sorteado foi: %numero%
   echo ----------------------------------------
   pause > nul 
   goto:sair )
   
   
if %palpite% LSS %numero% (
   echo.
   echo ----------------------------------------
   echo        Digite um numero maior 
   echo ----------------------------------------
   set /a cont=%cont%-1
   pause > nul
   goto:inicio ) else (
   echo.
   echo -----------------------------------------
   echo         Digite um numero menor 
   echo -----------------------------------------
   set /a cont=%cont%-1
   pause > nul
   goto:inicio )
   
 :sair
 echo.
 set /p resp=DESEJA JOGAR NOVAMENTE? [S/N]:
 if /I %resp% == S (goto:sorteio) else (exit)