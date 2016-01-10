@echo off
pushd "%~dp0"
openssl req -new -x509 -key ILSpy_TemporaryKey.key -out ILSpy_TemporaryKey.crt -config .\openssl.cnf -days 365
openssl pkcs12 -export -nodes -inkey ILSpy_TemporaryKey.key -in ILSpy_TemporaryKey.crt -out ILSpy_TemporaryKey.pfx