@echo off
rem ocultara todas as linhas de comandos

title Programacao Scripts Batch

mode 60,30
rem resolucao da tela

color 02
rem cor do fundo "" apos cor da letra""

:inicio
cls
echo.
echo --------------------------------
echo 		  MENU PRINCIPAL
echo --------------------------------
echo [W]Executar Word
echo [E]Executar Excel
echo [P]Executar Power Point
echo [A]Executar Access
echo [I]Acessar a Web
echo [T]Testar Conexao Rede
echo [O]Outra Tela
echo [F]Finalizar Script
echo.
set/p op=DIGITE UMA OPCAO:

if /i %op% == w (Goto:word)
if /i %op% == e (Goto:excel)
if /i %op% == p (Goto:pp)
if /i %op% == a (Goto:access)
if /i %op% == i (Goto:web)
if /i %op% == t (Goto:teste)
if /i %op% == o (call tela2.bat)
if /i %op% == f (Goto:sair) else (
	echo.
	echo --------------------------------
	echo	      OPCAO INVALIDA!
	echo --------------------------------
	pause > nul
	goto:inicio)
	
:word 
start winword.exe
goto:inicio

:excel 
start excel.exe
goto:inicio

:pp
start powerpnt.exe
goto:inicio

:access
start msaccess.exe
goto:inicio

:web
echo.
set /p site=DIGITE O ENDERECO DA PAGINA:
start %site%
goto:inicio

:teste
echo.
set /p conexao=DIGITE O ENDERECO IP OU ENDERECO WEB:
ping %conexao% -t 
goto:inicio

:sair
echo.
set /p resp=DESEJA REALMENTE ENCERRAR O SCRIPT [S/N]:
if /i resp == s (else (goto:inicio)
rem if /i %resp% == s (exit) else (goto inicio)

