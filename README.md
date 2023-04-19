Hotel Management System

انا عملت اتنين projects واحد معمول ب normalized database و تقسيمة ال folders جواه صح
 (اسمه HotelManagment_Day11_Normalized_VIEW)

و التانى برضه معمول بنفس الطريقة بس معملتوش بال normalized database
 (اسمه HotelManagment_Day11) و ده اللى كامل.

هتلاقى برضو مع كل project ال database backup لل project ده.

ملحوظة ➖

انا معرفتش اكمل ال معمل بال normalized database نظرا لضيق الوقت و تراكم التاسكات بس هو معمول بنسبة 60%.

فى ال project الكبير و الصغير ، انا عامل asynchronous methods  - ال database هتت create اول تعمل build للـ project - هتلاقينى مقسم المشروع ل folders معينة زى (windows - pages - manager - viewmodels - models- migrations- Mappers-Configurations) و هكذا.

طبعا انا مستعمل ال binding فى الاتنين projects.

فى ال project الكبير ، انا عامل حاجة اسمها BaseViewModel ده اللى مسؤل عن الـ live validation + live binding ، و كل ال ViewModels بت inherit منه وبعدين ال object ده بيحصل له mapping لل model اللى هيضاف فى ال database وهنا يجي دور الـ entity framework فى انه ي map ال model فى ال database
