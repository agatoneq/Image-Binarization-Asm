# 🖼️ Image Binarization with SIMD Assembly and C#

A Windows desktop application for image binarization using thresholding, built in C#.  
Supports multiple binary processing backends, including **SIMD-optimized assembly routines**, with full multi-threading support.

Developed as a university project focused on performance comparison between **C#**, **assembly (SIMD)**, and **assembly (non-SIMD)** versions.

<p align="center">
  <img src="https://github.com/user-attachments/assets/6f11b8a1-7abe-4811-95dd-b8462372c7fc"/>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/3059bfbc-aba4-4300-8b7a-f4c553973b34" height="200px"/>
  <img src="https://github.com/user-attachments/assets/0b3bde28-d259-450c-bd0d-50585449756f" height="200px"/>
  <img src="https://github.com/user-attachments/assets/a59b7660-5c51-4933-a740-24ddb8330abd" height="200px"/>
</p>


## 🧠 About the Project

- Load and binarize bitmap images using a dynamic threshold (0–255)
- Visual preview and side-by-side comparison of results
- Multiple backends:
  - C# implementation
  - Assembly with SIMD (vector instructions)
  - Assembly without SIMD (educational comparison)
- Adjustable **thread count** (from 1 to 64)
- Real-time **execution time measurement** per backend
- GUI for selecting image and method


## 💻 Technologies Used

- C# (Windows Forms)
- Assembly (x64, SIMD SSE)
- Dynamic Link Libraries (DLLs)
- .NET Framework
- Multi-threading (thread pool)
- WinForms UI


## 📊 Performance

The app was benchmarked using images of different sizes (S, M, L) and varying thread counts.  
Results show significantly better scaling and performance for the C# version vs assembly under multithreading.  
SIMD version offered insight into low-level parallel processing, though performance was bottlenecked by instruction overhead.

## 🧑‍💻 Author

**Agata Sobczyk** – designed and implemented the entire system independently


## ▶️ How to Run

1. Open the solution in Visual Studio
2. Make sure `BinarizationAsm.dll` is referenced correctly in `Form1.cs`
3. Load a test image (BMP, JPG or PNG)
4. Select processing method (C#, ASM, ASM-NV)
5. Adjust threshold and number of threads
6. Click to apply and compare results

> Works best in Release mode. Ensure platform target is set to x64.


## 📜 License

Personal project created for educational exploration of low-level image processing.
