@echo off
 
title JOKENPO
mode 60,30
color 0a
:inicio
::cpu escolhe de 1 a 5
set /a cpu=%RANDOM% * 5 / 32768 + 1
set /a placar 
cls


echo           JOKENPO


echo           PLACAR: %placar%
echo Esolha um ataque:
echo [1] Pedra
echo [2] Papel
echo [3] Tesoura
echo [4] Humano
echo [5] Martelo

set /p player=
if %player%==1 (
set x=1
goto baixo
)
if %player%==2 (
set x=2
goto baixo
)
if %player%==3 (
set x=3
goto baixo
)
if %player%==4 (
set x=4
goto baixo
)
if %player%==5 (
set x=5
goto baixo
)
goto inicio
:baixo
if %x%==1 (
if %cpu%==1 (
echo Pedra vs Pedra
echo Empate
pause>nul
goto:inicio
)
)

if %x%==2 (
if %cpu%==2 (
echo Papel vs Papel
echo Empate
pause>nul
goto:inicio
)
)
if %x%==3 (
if %cpu%==3 (
echo Tesoura vs Tesoura
echo Empate
pause>nul
goto:inicio
)
)
if %x%==4 (
if %cpu%==4 (
echo Humano vs Humano
echo Empate
pause>nul
goto:inicio
)
)
if %x%==5 (
if %cpu%==5 (
echo Martelo vs Martelo
echo Empate
pause>nul
goto:inicio
)
)
if %x%==1 (
if %cpu%==2 (
echo Pedra vs Papel
echo Perdeu
pause>nul
goto inicio
)
)
if %x%==1 (
if %cpu%==3 (
echo Pedra vs Tesoura
echo Ganhou
pause>nul
goto inicio
)
)

if %x%==1 (
if %cpu%==4 (
echo Pedra vs Humano
echo Ganhou
pause>nul
goto inicio
)
)
if %x%==1 (
if %cpu%==5 (
echo Pedra vs Martelo
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==2 (
if %cpu%==1 (
echo Papel vs Pedra
echo Ganhou
pause>nul
goto inicio
)
)
if %x%==2 (
if %cpu%==3 (
echo Papel vs Tesoura
echo Perdeu
pause>nul
goto inicio
)
)
if %x%==2 (
if %cpu%==4 (
echo Papel vs Humano
echo Perdeu
pause>nul
goto inicio
)
)
if %x%==2 (
if %cpu%==5 (
echo Papel vs Martelo
echo Perdeu
pause>nul
goto inicio
)
)
if %x%==3 (
if %cpu%==1 (
echo Tesoura vs Pedra
echo Perdeu
pause>nul
goto inicio
)
)
if %x%==3 (
if %cpu%==2 (
echo Tesoura vs Papel
echo Ganhou!
pause>nul
goto inicio
)
)
if %x%==3 (
if %cpu%==4 (
echo Tesoura vs Humano
echo Ganhou
pause>nul
goto inicio
)
)
if %x%==3 (
if %cpu%==5 (
echo Tesoura vs Martelo
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==4 (
if %cpu%==1 (
echo Humano vs Pedra
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==4 (
if %cpu%==2 (
echo Humano vs Papel
echo Ganhou
pause>nul
goto inicio
)
)

if %x%==4 (
if %cpu%==3 (
echo Humano vs Tesoura
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==4 (
if %cpu%==5 (
echo Humano vs Martelo
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==5 (
if %cpu%==1 (
echo Martelo vs Pedra
echo Ganhou
pause>nul
goto inicio
)
)

if %x%==5 (
if %cpu%==2 (
echo Martelo vs Papel
echo Perdeu
pause>nul
goto inicio
)
)

if %x%==5 (
if %cpu%==4 (
echo Martelo vs Humano
echo Perdeu!
pause>nul
goto inicio
)
)

if %x%==5 (
if %cpu%==3 (
echo Martelo vs Tesoura
echo Ganhou
pause>nul
goto inicio
)
)
if 
pause>nul