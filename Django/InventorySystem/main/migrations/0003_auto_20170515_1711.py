# -*- coding: utf-8 -*-
# Generated by Django 1.11 on 2017-05-15 11:41
from __future__ import unicode_literals

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0002_categories'),
    ]

    operations = [
        migrations.RenameField(
            model_name='categories',
            old_name='CategoryName',
            new_name='category',
        ),
        migrations.RemoveField(
            model_name='product',
            name='Category',
        ),
        migrations.RemoveField(
            model_name='sales_entry',
            name='Category',
        ),
        migrations.AddField(
            model_name='product',
            name='category',
            field=models.ForeignKey(default=1, on_delete=django.db.models.deletion.CASCADE, to='main.categories'),
        ),
        migrations.AddField(
            model_name='sales_entry',
            name='category',
            field=models.ForeignKey(default=1, on_delete=django.db.models.deletion.CASCADE, to='main.categories'),
        ),
    ]