## .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.Imperative()
       mov     rax,qword ptr [rcx+8]
       test    rax,rax
       je      M00_L00
       add     rsp,20h
       pop     rsi
       ret
M00_L00:
       mov     rcx,offset mscorlib_ni+0xa4bb0
       call    clr+0x2510
       mov     rsi,rax
       mov     ecx,0BFh
       mov     rdx,7FF97C5B8280h
       call    clr!StrongNameTokenFromPublicKey+0x1ff70
       mov     rdx,rax
       mov     rcx,rsi
       call    qword ptr [mscorlib_ni+0x1ecc18
       mov     rcx,rsi
       call    clr!LogHelp_LogAssert+0x169e0
       int     3
       add     byte ptr [rcx],bl
       add     eax,32050002h
       add     dword ptr [rax+40h],esp
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
; Total bytes of code 98
```

## .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.LightGuardClauses()
       sub     rsp,28h
       xor     edx,edx
       mov     qword ptr [rsp+20h],rdx
       mov     rdx,qword ptr [rcx+8]
       mov     r8,25742451BB8h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF97C60E418h
       xor     r9d,r9d
       call    Benchmarks.MustNotBeNullAssertions.MustNotBeNullOld[[System.__Canon, mscorlib]](System.__Canon, System.String, System.String, System.Func`1<System.Exception>)
       nop
       add     rsp,28h
       ret
       sbb     dword ptr [rcx+rax],eax
       add     byte ptr [rdx+rax*2],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     al,cl
       jmp     qword ptr [rcx+7Ch]
       stc
       jg      00007ff9`7c529fef
; Total bytes of code 79
```
```assembly
; Benchmarks.MustNotBeNullAssertions.MustNotBeNullOld[[System.__Canon, mscorlib]](System.__Canon, System.String, System.String, System.Func`1<System.Exception>)
       test    rdx,rdx
       je      M01_L00
       mov     rax,rdx
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M01_L00:
       mov     rax,qword ptr [rsp+60h]
       test    rax,rax
       jne     M01_L01
       xor     ebx,ebx
       jmp     M01_L02
M01_L01:
       lea     rcx,[rax+8]
       mov     rcx,qword ptr [rcx]
       call    qword ptr [rax+18h]
       mov     rbx,rax
M01_L02:
       test    rbx,rbx
       jne     00007ff9`7c52a0bc
       mov     rbx,rsi
       test    rdi,rdi
       jne     00007ff9`7c52a066
       mov     rcx,rsi
       test    rsi,rsi
       jne     M01_L03
       mov     rcx,25742451BC0h
       mov     rcx,qword ptr [rcx]
M01_L03:
       mov     rbx,rsi
       mov     rdx,25742451BC8h
; Total bytes of code 94
```

## .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.Simple()
       mov     rdx,qword ptr [rcx+8]
       mov     r8,1D154711BB8h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF97C5EE418h
       xor     r9d,r9d
       mov     rax,7FF97C508C68h
       jmp     rax
       add     byte ptr [rcx],bl
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       enter   5FFFh,7Ch
       stc
       jg      M00_L00
M00_L00:
       add     byte ptr [rdi+56h],dl
       push    rbx
       sub     rsp,20h
       test    rdx,rdx
; Total bytes of code 74
```

## .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.AggressiveInlining()
       mov     rax,qword ptr [rcx+8]
       test    rax,rax
       je      M00_L00
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
M00_L00:
       mov     rcx,1485B941BB8h
       mov     rsi,qword ptr [rcx]
       mov     rcx,1485B941BC0h
       mov     rdi,qword ptr [rcx]
       mov     rcx,offset mscorlib_ni+0xa4bb0
; Total bytes of code 53
```

## .NET Framework 4.8 (4.8.4042.0), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.ExternalThrowCall()
       mov     rax,qword ptr [rcx+8]
       test    rax,rax
       je      M00_L00
       add     rsp,28h
       ret
M00_L00:
       mov     rcx,2B547CA1BB8h
       mov     rcx,qword ptr [rcx]
       xor     edx,edx
       call    Benchmarks.Throw.ArgumentNull(System.String, System.String)
       int     3
       add     byte ptr [rcx],bl
       add     al,1
       add     byte ptr [rdx+rax*2],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
; Total bytes of code 47
```
**Method got most probably inlined**
Benchmarks.Throw.ArgumentNull(System.String, System.String)

## .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.Imperative()
       mov     rax,qword ptr [rbp+10h]
       cmp     qword ptr [rax+8],0
       jne     M00_L00
       mov     rcx,7FF95C0FC980h
       call    coreclr!coreclr_shutdown_2+0xcb80
       mov     qword ptr [rbp-8],rax
       mov     ecx,0BFh
       mov     rdx,7FF95C1FC5B0h
       call    coreclr!GetCLRRuntimeHost+0x740d0
       mov     qword ptr [rbp-10h],rax
       mov     rdx,qword ptr [rbp-10h]
       mov     rcx,qword ptr [rbp-8]
       call    System.ArgumentNullException..ctor(System.String)
       mov     rcx,qword ptr [rbp-8]
       call    coreclr!coreclr_initialize+0xb9420
M00_L00:
       mov     rax,qword ptr [rbp+10h]
       mov     rax,qword ptr [rax+8]
; Total bytes of code 84
```
**Method got most probably inlined**
System.ArgumentNullException..ctor(System.String)

## .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.LightGuardClauses()
       xor     edx,edx
       mov     qword ptr [rsp+20h],rdx
       mov     rdx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rdx+8]
       mov     r8,1C369129BB0h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF95C394D98h
       xor     r9d,r9d
       call    Benchmarks.MustNotBeNullAssertions.MustNotBeNullOld[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String, System.Func`1<System.Exception>)
; Total bytes of code 46
```
```assembly
; Benchmarks.MustNotBeNullAssertions.MustNotBeNullOld[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String, System.Func`1<System.Exception>)
       cmp     qword ptr [rbp+18h],0
       je      M01_L00
       mov     rax,qword ptr [rbp+18h]
       lea     rsp,[rbp-10h]
       pop     rsi
       pop     rdi
       pop     rbp
       ret
M01_L00:
       cmp     qword ptr [rbp+30h],0
       jne     M01_L01
       xor     ecx,ecx
       mov     qword ptr [rbp-18h],rcx
       jmp     M01_L02
M01_L01:
       mov     rcx,qword ptr [rbp+30h]
       mov     qword ptr [rbp-50h],rcx
       mov     rcx,qword ptr [rbp-50h]
       mov     rcx,qword ptr [rcx+8]
       mov     rax,qword ptr [rbp-50h]
       call    qword ptr [rax+18h]
       mov     qword ptr [rbp-18h],rax
M01_L02:
       mov     rdx,qword ptr [rbp-18h]
       mov     qword ptr [rbp-20h],rdx
       cmp     qword ptr [rbp-18h],0
       jne     00007ff9`5c2f97cc
       mov     rdx,qword ptr [rbp+20h]
       mov     qword ptr [rbp-28h],rdx
       mov     rdx,qword ptr [rbp+28h]
       mov     qword ptr [rbp-30h],rdx
       cmp     qword ptr [rbp+28h],0
       jne     00007ff9`5c2f97a0
       mov     rdx,qword ptr [rbp-28h]
       mov     qword ptr [rbp-40h],rdx
       mov     rdx,qword ptr [rbp+20h]
       mov     qword ptr [rbp-48h],rdx
       cmp     qword ptr [rbp+20h],0
       jne     00007ff9`5c2f977e
       mov     rdx,1C369129BB8h
; Total bytes of code 136
```

## .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.Simple()
       mov     rdx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rdx+8]
       mov     r8,17CC9259BB0h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF95C374D98h
       xor     r9d,r9d
       call    Benchmarks.MustNotBeNullAssertions.MustNotBeNullV1[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
; Total bytes of code 39
```
```assembly
; Benchmarks.MustNotBeNullAssertions.MustNotBeNullV1[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
       cmp     qword ptr [rbp+18h],0
       jne     M01_L01
       mov     rax,qword ptr [rbp+20h]
       mov     qword ptr [rbp-18h],rax
       mov     rax,qword ptr [rbp+28h]
       mov     qword ptr [rbp-20h],rax
       cmp     qword ptr [rbp+28h],0
       jne     M01_L00
       mov     rax,17CC9259BB8h
       mov     rax,qword ptr [rax]
       mov     qword ptr [rbp-20h],rax
M01_L00:
       mov     rcx,7FF95C10C980h
       call    coreclr!coreclr_shutdown_2+0xcb80
       mov     qword ptr [rbp-28h],rax
       mov     ecx,99h
       mov     rdx,7FF95C20C5B0h
       call    coreclr!GetCLRRuntimeHost+0x740d0
       mov     qword ptr [rbp-30h],rax
       mov     rdx,qword ptr [rbp-30h]
       mov     rcx,qword ptr [rbp-20h]
       call    System.String.Concat(System.String, System.String)
       mov     qword ptr [rbp-38h],rax
       mov     r8,qword ptr [rbp-38h]
       mov     rdx,qword ptr [rbp-18h]
       mov     rcx,qword ptr [rbp-28h]
       call    System.ArgumentNullException..ctor(System.String, System.String)
       mov     rcx,qword ptr [rbp-28h]
       call    coreclr!coreclr_initialize+0xb9420
M01_L01:
       mov     rax,qword ptr [rbp+18h]
; Total bytes of code 141
```

## .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.AggressiveInlining()
       mov     rdx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rdx+8]
       mov     r8,27AB6A69BB0h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF95C354D98h
       xor     r9d,r9d
       call    Benchmarks.MustNotBeNullAssertions.MustNotBeNullV2[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
; Total bytes of code 39
```
```assembly
; Benchmarks.MustNotBeNullAssertions.MustNotBeNullV2[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
       cmp     qword ptr [rbp+18h],0
       jne     M01_L01
       mov     rax,qword ptr [rbp+20h]
       mov     qword ptr [rbp-18h],rax
       mov     rax,qword ptr [rbp+28h]
       mov     qword ptr [rbp-20h],rax
       cmp     qword ptr [rbp+28h],0
       jne     M01_L00
       mov     rax,27AB6A69BB8h
       mov     rax,qword ptr [rax]
       mov     qword ptr [rbp-20h],rax
M01_L00:
       mov     rcx,7FF95C0EC980h
       call    coreclr!coreclr_shutdown_2+0xcb80
       mov     qword ptr [rbp-28h],rax
       mov     ecx,99h
       mov     rdx,7FF95C1EC5B0h
       call    coreclr!GetCLRRuntimeHost+0x740d0
       mov     qword ptr [rbp-30h],rax
       mov     rdx,qword ptr [rbp-30h]
       mov     rcx,qword ptr [rbp-20h]
       call    System.String.Concat(System.String, System.String)
       mov     qword ptr [rbp-38h],rax
       mov     r8,qword ptr [rbp-38h]
       mov     rdx,qword ptr [rbp-18h]
       mov     rcx,qword ptr [rbp-28h]
       call    System.ArgumentNullException..ctor(System.String, System.String)
       mov     rcx,qword ptr [rbp-28h]
       call    coreclr!coreclr_initialize+0xb9420
M01_L01:
       mov     rax,qword ptr [rbp+18h]
; Total bytes of code 141
```

## .NET Core 3.1.0 (CoreCLR 4.700.19.56402, CoreFX 4.700.19.56404), X64 RyuJIT
```assembly
; Benchmarks.MustNotBeNullBenchmark.ExternalThrowCall()
       mov     rdx,qword ptr [rbp+10h]
       mov     rdx,qword ptr [rdx+8]
       mov     r8,25590009BB0h
       mov     r8,qword ptr [r8]
       mov     rcx,7FF95C374D98h
       xor     r9d,r9d
       call    Benchmarks.MustNotBeNullAssertions.MustNotBeNullV3[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
; Total bytes of code 39
```
```assembly
; Benchmarks.MustNotBeNullAssertions.MustNotBeNullV3[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.String, System.String)
       cmp     qword ptr [rbp+18h],0
       jne     M01_L00
       mov     rcx,qword ptr [rbp+20h]
       mov     rdx,qword ptr [rbp+28h]
       call    Benchmarks.Throw.ArgumentNull(System.String, System.String)
M01_L00:
       mov     rax,qword ptr [rbp+18h]
; Total bytes of code 24
```

