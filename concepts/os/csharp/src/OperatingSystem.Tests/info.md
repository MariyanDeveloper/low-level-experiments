When writing assembly code we can:
✅ Arithmetic: add, subtract, multiply, divide
✅ Move data between CPU registers
✅ Load/store data in RAM (read/write memory)
✅ Control flow: jumps, loops, function calls
✅ Work with the stack (call frames, local variables)
✅ Handle CPU-specific features (flags, interrupts if allowed)
👉 These are instructions executed directly by the CPU — no OS involved here.

but there are actions that we need Operating system for
❌ Interacting with files on disk (read/write files)
❌ Printing text to console or GUI
❌ Using the network (send/receive packets)
❌ Allocating memory dynamically (beyond stack / static data)
❌ Managing timers
❌ Talking to devices like keyboard, mouse, GPU

→ You can talk to your own memory and registers anytime.
→ But to cross the barrier into the outside world (files, console, network), you need to make a request to the OS.

When your program needs the OS to do something on its behalf — such as:

- read/write files
- print to console
- allocate memory
- open network sockets
- create new processes
- interact with devices

👉 You invoke a system call (syscall for short).

![app_task_manager](img.png)
This is what we have for our simple console log app,
"Private Working Set" = the amount of physical RAM pages that are currently mapped for your process, and are private (not shared with other processes).