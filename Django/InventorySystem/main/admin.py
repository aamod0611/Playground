from django.contrib import admin

from . models import Product,Sales_entry,categories

admin.site.register(Product)
admin.site.register(Sales_entry)
admin.site.register(categories)