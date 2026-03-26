import pandas as pd

# Load your CSV
df = pd.read_csv("../data/us_monthly_prod_bbpd.csv")

# Quick check
print(df.head())
print(df.info())