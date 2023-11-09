@echo off
rem ocultara todas as linhas de comandos

title Programacao Scripts Batch

mode 60,30
rem resolucao da tela

color 03
rem cor do fundo "" apos cor da letra""

:inicio
cls
echo.
echo --------------------------------
echo 		  OUTRA TELA
echo --------------------------------
echo [R]RETORNAR AO MENU
echo [T]ABRIR TODOS MICROSOFT JUNTOS

echo.
set/p op=DIGITE UMA OPCAO:

if /i %op% == R (call exercicio001.bat)
if /i %op% == T (goto:todos)
	else (
	echo.
	echo --------------------------------
	echo	      OPCAO INVALIDA!
	echo --------------------------------
	pause > nul
	goto:inicio)
	
:todos 
start winword.exe
start excel.exe
start powerpnt.exe
start msaccess.exe

goto:inicio

