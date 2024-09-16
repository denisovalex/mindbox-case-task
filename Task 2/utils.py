def get_pairs(products_df, categories_df, product_category_df):
    
    product_category_joined = product_category_df \
    .join(products_df, on='product_id') \
    .join(categories_df, on='category_id')

    product_category_pairs = product_category_joined \
    .select('product_name', 'category_name')

    return product_category_pairs

def get_products_without_categories(products_df, product_category_df):

    products_with_categories = products_df \
    .join(product_category_df, on='product_id') \
    .select('product_id', 'product_name').distinct()

    products_without_categories = products_df \
    .select('product_id', 'product_name') \
    .subtract(products_with_categories)

    return products_without_categories
