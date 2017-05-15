from django.db import models
from django.core.urlresolvers import reverse


class categories(models.Model):
    CategoryId = models.AutoField(primary_key=True)
    category = models.CharField(max_length=50)

    def __str__(self):
        return self.category

class Product(models.Model):
    ProductCode = models.CharField(max_length=10)
    ProductName = models.CharField(max_length=50)
    #Category = models.CharField(max_length=50)
    Category = models.ForeignKey(categories, default=1)
    UnitPrice = models.CharField(max_length=10)
    QtyInStock = models.CharField(max_length=10)
    IsDiscontinued = models.CharField(max_length=5)
    ReOrderLevel = models.CharField(max_length = 5)

    def get_absolute_url(self):
        return reverse('main:index', kwargs={'pk': self.pk})

    def __str__(self):
        return self.ProductName

class Sales_entry(models.Model):
    category = models.ForeignKey(categories, default=1)
    Product = models.CharField(max_length=50)
    QtySold = models.CharField(max_length=10)
    Rate = models.CharField(max_length=10)

    def __str__(self):
        return self.Product

