# Используем официальный образ Python
FROM python:3.11.3

WORKDIR /

COPY . /

# RUN pip install --upgrade pip && pip install pdf2docx && pip install docx2pdf && pip install Pillow

RUN pip install --no-cache-dir -r /requirements.txt
# Копируем исходный код в образ
# Задаем рабочую директорию
# Экспонируем порт 5000
EXPOSE 5000
# Определяем команду, которая будет выполняться при запуске контейнера
CMD ["python", "main.py"]

