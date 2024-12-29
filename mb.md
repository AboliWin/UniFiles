حتماً! در اینجا توضیح خط به خط کد به زبان فارسی آورده شده است.

### 1. اعلام و مقداردهی آرایه‌ها

```csharp
int[] array1 = new int[10];
int[] array2 = new int[10];
```

- در اینجا دو آرایه به نام‌های `array1` و `array2` اعلام می‌کنیم. هر دو آرایه دارای اندازه 10 هستند، یعنی هرکدام 10 عدد صحیح را ذخیره می‌کنند. در ابتدا، این آرایه‌ها با مقادیر پیش‌فرض پر می‌شوند (عدد 0 برای نوع داده `int`).

### 2. تولید عدد تصادفی

```csharp
Random random = new Random();
```

- در اینجا یک شیء از کلاس `Random` می‌سازیم که برای تولید اعداد تصادفی استفاده می‌شود.

```csharp
for (int i = 0; i < 10; i++)
{
    array1[i] = random.Next(1, 21);
    array2[i] = random.Next(1, 21);
}
```

- این یک حلقه `for` است که 10 بار اجرا می‌شود (از `i = 0` تا `i = 9`).
- در هر بار اجرای حلقه، یک عدد تصادفی بین 1 و 20 به آرایه‌های `array1` و `array2` اختصاص داده می‌شود. تابع `random.Next(1, 21)` یک عدد تصادفی بین 1 و 20 تولید می‌کند (عدد 21 به طور انحصاری خارج از محدوده است).

### 3. چاپ آرایه‌ها قبل از جستجو

```csharp
Console.WriteLine("Array 1 (before search):");
PrintArray(array1);
Console.WriteLine("Array 2 (before search):");
PrintArray(array2);
```

- قبل از جستجو برای یک عدد خاص، محتویات هر دو آرایه را چاپ می‌کنیم. برای این کار از متد `PrintArray()` استفاده می‌کنیم.

### 4. جستجو برای یک عدد در آرایه‌ها

```csharp
Console.Write("Enter a number to search (1-20): ");
int userNumber = int.Parse(Console.ReadLine());
```

- از کاربر می‌خواهیم عددی وارد کند که می‌خواهیم آن را در آرایه‌ها جستجو کنیم. `Console.ReadLine()` ورودی را به صورت رشته می‌خواند و `int.Parse()` آن را به یک عدد صحیح (`userNumber`) تبدیل می‌کند.

```csharp
SearchInArray(array1, userNumber, "Array 1");
SearchInArray(array2, userNumber, "Array 2");
```

- سپس از متد `SearchInArray()` برای جستجو در هر دو آرایه استفاده می‌کنیم. این متد شماره وارد شده توسط کاربر را در آرایه‌ها جستجو می‌کند و مشخص می‌کند که آیا این عدد در آرایه‌ها وجود دارد یا خیر.

### 5. مرتب‌سازی آرایه‌ها

```csharp
Array.Sort(array1);
Array.Sort(array2);
```

- با استفاده از متد `Array.Sort()`، هر دو آرایه را به صورت صعودی مرتب می‌کنیم. این متد مقادیر آرایه‌ها را از کوچکترین به بزرگترین ترتیب می‌دهد.

### 6. چاپ آرایه‌ها پس از مرتب‌سازی

```csharp
Console.WriteLine("\nArray 1 (after sorting):");
PrintArray(array1);
Console.WriteLine("Array 2 (after sorting):");
PrintArray(array2);
```

- پس از مرتب‌سازی آرایه‌ها، دوباره محتویات آن‌ها را چاپ می‌کنیم تا ببینیم که چگونه آرایه‌ها مرتب شده‌اند.

### 7. ترکیب دو آرایه در یک آرایه جدید

```csharp
int[] mergedArray = new int[20];
array1.CopyTo(mergedArray, 0);
array2.CopyTo(mergedArray, 10);
```

- یک آرایه جدید به نام `mergedArray` به اندازه 20 عنصر اعلام می‌کنیم، زیرا می‌خواهیم دو آرایه 10 عنصری را با هم ترکیب کنیم.
- `array1.CopyTo(mergedArray, 0)` تمام عناصر `array1` را به آرایه `mergedArray` از اندیس 0 کپی می‌کند.
- `array2.CopyTo(mergedArray, 10)` تمام عناصر `array2` را به آرایه `mergedArray` از اندیس 10 کپی می‌کند. این باعث می‌شود که نیمه اول `mergedArray` شامل مقادیر `array1` و نیمه دوم شامل مقادیر `array2` باشد.

### 8. چاپ آرایه ترکیب‌شده

```csharp
Console.WriteLine("\nMerged Array:");
PrintArray(mergedArray);
```

- در اینجا، محتویات آرایه `mergedArray` را چاپ می‌کنیم تا ببینیم که دو آرایه چگونه به یکدیگر ترکیب شده‌اند.

### 9. متد کمکی برای چاپ آرایه‌ها

```csharp
static void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
```

- این متد کمکی به نام `PrintArray()` است که برای چاپ مقادیر آرایه استفاده می‌شود. از یک حلقه `foreach` برای عبور از تمام عناصر آرایه استفاده می‌کند و هر عدد را همراه با یک فاصله چاپ می‌کند. پس از اتمام چاپ تمام عناصر، `Console.WriteLine()` برای رفتن به خط بعدی اجرا می‌شود.

### 10. متد کمکی برای جستجو در آرایه‌ها

```csharp
static void SearchInArray(int[] array, int number, string arrayName)
{
    bool found = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            Console.WriteLine($"{arrayName}: Number {number} found at index {i}");
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine($"{arrayName}: Number {number} not found.");
    }
}
```

- این متد به نام `SearchInArray()` به سه پارامتر نیاز دارد:
  - `array`: آرایه‌ای که می‌خواهیم در آن جستجو کنیم.
  - `number`: عددی که می‌خواهیم آن را جستجو کنیم.
  - `arrayName`: نام آرایه که به صورت رشته (مثلاً "Array 1" یا "Array 2") به متد داده می‌شود.
  
- با استفاده از یک حلقه `for`، آرایه را مرور می‌کنیم. اگر عدد مورد نظر را در آرایه پیدا کردیم، موقعیت آن (ایندکس) را چاپ می‌کنیم.
- اگر عدد مورد نظر را پیدا نکردیم، پیامی چاپ می‌کنیم که نشان می‌دهد عدد در آرایه وجود ندارد.

### مثال خروجی

فرض کنید کد را اجرا کرده و این ورودی‌ها را وارد کنید:

#### آرایه‌ها قبل از جستجو (پر شده با اعداد تصادفی)

```
Array 1 (before search):
15 4 17 3 7 19 18 13 5 6
Array 2 (before search):
16 2 10 9 12 11 14 20 1 8
```

#### ورودی کاربر

```
Enter a number to search (1-20): 7
```

- در اینجا برنامه به دنبال عدد 7 می‌گردد.

#### نتایج جستجو

```
Array 1: Number 7 found at index 4
Array 2: Number 7 not found.
```

- عدد 7 در `array1` در ایندکس 4 پیدا شد، ولی در `array2` پیدا نشد.

#### آرایه‌ها پس از مرتب‌سازی

```
Array 1 (after sorting):
3 4 5 6 7 13 15 17 18 19
Array 2 (after sorting):
1 2 8 9 10 11 12 14 16 20
```

- هر دو آرایه به صورت صعودی مرتب شده‌اند.

#### آرایه ترکیب‌شده

```
Merged Array:
3 4 5 6 7 13 15 17 18 19 1 2 8 9 10 11 12 14 16 20
```

- آرایه ترکیب‌شده، که شامل همه مقادیر `array1` (مرتب شده) و سپس همه مقادیر `array2` (مرتب شده) است، چاپ می‌شود.

---

امیدوارم این توضیحات به شما کمک کند تا کد را به خوبی درک کنید. اگر سؤال یا قسمتی نیاز به توضیح بیشتر دارد، خوشحال می‌شوم کمک کنم!
