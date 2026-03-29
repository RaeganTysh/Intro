import os
# print (os.getcwd())

# Set working directory to the script's folder
# Explanation:
# __file__ → the full path of analysis.py.
# os.path.abspath(__file__) → absolute path in case it’s relative.
# os.path.dirname(...) → the folder containing analysis.py.
# os.chdir(...) → changes Python’s current working directory to that folder.

os.chdir(os.path.dirname(os.path.abspath(__file__)))  

import pandas as pd
# import matplotlib.pyplot as plt

# Load your CSV for EDA
# df = pd.read_csv("../data/us_monthly_prod_bbpd.xls")
# Returns dict with sheet names as keys
# all_sheets = pd.read_excel("../data/us_monthly_prod_bbpd.xls", sheet_name=None)
# print(all_sheets.keys())  # Shows ALL sheet names
# second_sheet = all_sheets['Data 1']  # Access by name
# df_contents = pd.read_excel("../data/us_monthly_prod_bbpd.xls", sheet_name= "Contents")

# Quick check sheet 1- contents - EDA
# print(df_contents.head(20))  # first 5 rows vibe check
# print(df_contents.info())  # rows, columns, data types, missing values
# print(df_contents.shape) #simple tupple of rows, columns

# Quick check sheet 2- data -EDA
# pd.set_option('display.max_columns', None)  #use before head if you want to see all columns
#print(df_data.head())  # first 5 rows vibe check
#print(df_data.info())  # rows, columns, data types, missing values
# print(df_data.shape) #simple tupple of rows, columns
# print(df_data.shape[0]) # shows # of rows
# print(df_data.shape[1]) # shows # of columns
# print(df_data.columns.tolist()) 

df_data = pd.read_excel("../data/us_monthly_prod_bbpd.xls", sheet_name= "Data 1", skiprows=2) 
# df_data = pd.read_excel("../data/us_monthly_prod_bbpd.xls", sheet_name= "Data 1")


# Convert the first column to actual datetime objects
df_data.iloc[:, 0] = pd.to_datetime(df_data.iloc[:, 0]).dt.date # do not need time
# Set the date as the index so you can slice by time- optional
df_data.set_index(df_data.columns[0], inplace=True)

# 3. Create the "History" DataFrame (Date and Total Production only)
# We use .iloc[:, 0:2] to say "give me all rows and the first two columns"
df_history = df_data.iloc[:, 0:1].copy()

#Confirm eveything looks ok for historical df
#print (df_history.info())
#print (df_history.head())
# print("History Range:", df_history.index.min(), "to", df_history.index.max())
# %Y-%m-%d gives you "1920-01-01" - removes the time stamp
# print("History Range:", df_history.index.min().strftime('%Y-%m-%d'), 
#       "to", df_history.index.max().strftime('%Y-%m-%d'))
#print(df_history.shape)


# dropna() removes any row that has a missing value in the specified column
# We use the second column (MCRFPP12) as the 'anchor' for when data started
#df_detailed = df_data.dropna(subset=[df_data.columns[1]])

#Confirm eveything looks ok for detailed df
# print(df_detailed.head())
# print(df_detailed.shape)
# print("Detailed Range:", df_detailed.index.min(), "to", df_detailed.index.max())
# Remove time stamp
# print("History Range:", df_detailed.index.min().strftime('%Y-%m-%d'), 
#       "to", df_detailed.index.max().strftime('%Y-%m-%d'))

#check ranges and averages- stats
# print(df_history.describe())
# How many blanks are in each column
# print(df_history.isnull().sum())
# Only look at the columns you actually care about and traspose for better viewing
#summary = df_detailed.describe().T  #makes it scannable
# print(summary[['mean', 'min', 'max']].round(0)) #removes noise 
#print(summary.sort_values(by='mean', ascending=False).round(0)) #sort
# How many blanks are in each column
#print(df_detailed.isnull().sum())
# Keeps only columns where the SUM of the values is greater than 0
# (Since NaN and 0 both sum to 0, this removes Idaho perfectly)

#If remove states that are not significant have mean production less that 5(5000 barrels/day)- Scale (won't even show up on a chart next to others), Statistical drag (pulls Average Us State prodcution down), removes spikes (inconsistent reporting or barely hit the threshold which is 1000 barrels/day) - will no longer match historical production 
#South Dakota, Nevada, Tennessee, New York, Missouri, Arizona, Idaho, Virginia- 8 states - keep 34

# 1. Calculate the mean, explicitly skipping NA values
#column_means = df_detailed.mean(skipna=True)

# 2. Identify which column names pass the "Greater than 5" test - list of names pass test
# active_columns = column_means[column_means > 5].index
# inactive_columns = column_means[column_means <= 5].index

# 3. Create the new dataframe using those specific names
# df_significant_active = df_detailed[active_columns].copy() # give me only the active columns in the dataframe 
# df_inactive = df_detailed[inactive_columns].copy() #copy saves it as a new object not just a view or window- reduces errors going forward

# 4. Check the results
# print(f"Active States Remaining: {len(df_significant_active.columns)}")
# print(f"Inactive States: {len(df_inactive.columns)}")
# summary_active= df_significant_active.describe().T
# print(summary_active.sort_values(by='mean', ascending=False).round(0))
#print(df_significant_active.columns.tolist()) #not that useful here


#Notes- split data set into historical total us production (1920-2025) and detailed by region (1982-2025)
#Lump states that are not significant have mean production less that 10(10000 barrels/day)- Scale (won't even show up on a chart next to others), Statistical drag (pulls Average Us State prodcution down), removes spikes (inconsistent reporting or barely hit the threshold which is 1000 barrels/day)
#South Dakota, Nevada, Tennessee, New York, Missouri, Arizona, Idaho, Virginia
#Pie charts will look professional no weird 0.00001% slices. Line charts are clean , Totals remain honest and mathematically sound

# 1. Separate the Big Producers from the Small ones
# threshold = 10 
# mean_production = df_detailed.mean()

# big_states = mean_production[mean_production >= threshold].index.tolist()
# small_states = mean_production[mean_production < threshold].index.tolist()

# # 2. Create the "Other States" column by summing the small ones
# df_detailed_final = df_detailed[big_states].copy()
# df_detailed_final['Other States'] = df_detailed[small_states].sum(axis=1) #axis zero sums columns axis 1 sums rows (treats NAN as 0)

# # 3. Verify: The new 'Other States' should be a nice, manageable number
# print(df_detailed_final[['Other States']].describe().T.round(0))
# print(summary.sort_values(by='mean', ascending=False).round(0)) #sort
# #doulble dipping because regional and state in the same one. 

# need split this set into 3 seperate dataframes- history, regional, state
# 1. THE STATE-LEVEL BUCKET (The "Parts")
# Filter out 'PADD' and 'U.S.' to get individual states only
state_cols = [col for col in df_data.columns if "PADD" not in col and "U.S." not in col]
df_states = df_data[state_cols].copy()
# print(df_states.info()) #540 non-null
# print(df_states.shape) #1272, 35
# Confirmed 540 is the 'Detailed Era' length - start recording in Jan 1981
df_states_clean = df_states.tail(540).copy()
#or use date splicer after confirmation of dates below
#df_states_clean = df_states.loc['1981-01-01':].copy()
#confirm
# print(df_states_clean.head())
# print(df_states_clean.tail())

# #Confirm all recording start dates
# #  Find the first valid date for EVERY state
# start_dates = df_states.apply(lambda col: col.first_valid_index())

# # The 'latest' of these dates is when the whole group is finally 'ready'
# master_start_date = start_dates.max()

# print(f"To have 100% complete data for all states, we must start at: {master_start_date}") #2007-01-15

# #Find the start date for every column and pick the latest one
# latest_start_date = df_states.apply(lambda col: col.first_valid_index()).max()

# print(f"The 'Full House' date is: {latest_start_date}")  #2007-01-15

# # Create a sorted list of when each state started reporting
# start_timeline = df_states.apply(lambda col: col.first_valid_index()).sort_values()

# print("State Reporting Timeline:")
# print(start_timeline)

# Alaska strated recording 1960's, Idaho in 2007 (small insignificant player) bulk of data in 1981
# How to decide?
# "Is the story I'm telling about the 2010s Fracking Boom, or the long-term decline and recovery of US Oil?"

# Fracking Boom: Start in 2007. It's cleaner, and that's when the modern era really began anyway.

# Long-Term Story: Start in 1981. Just add a footnote in your analysis stating: "Alaska data added to the set in 2007."



# Check 
# summary_states = df_states.describe().T  #makes it scannable
# print(summary_states[['mean', 'min', 'max']].round(0)) #removes noise 
# print(summary_states.sort_values(by='mean', ascending=False).round(0)) #sort
# print(summary_states.head())
#print(summary_states.shape) #35 states 8 columns in describe

# Clean up column names
df_states_clean.columns = [col.split(' Field')[0] for col in df_states.columns]

# APPLY YOUR THRESHOLD LOGIC (On States Only)
threshold = 10
state_means = df_states_clean.mean()

big_states = state_means[state_means >= threshold].index.tolist()
small_states = state_means[state_means < threshold].index.tolist()
print(small_states)

# #Check the results
# # 1. Run the counts
# num_big = len(big_states)
# num_small = len(small_states)
# total_states_processed = num_big + num_small

# # 2. Print the Audit
# print(f"--- STATE SPLIT AUDIT (Threshold: {threshold}) ---")
# print(f"Big Producers (>= {threshold}k): {num_big}")
# print(f"Small Producers (< {threshold}k): {num_small}")
# print(f"Total Individual States: {total_states_processed}")
# print("-" * 30)

# # 3. Peek at the lists to ensure no 'PADD' or 'U.S.' leaked in
# print("\nFirst 5 Big States:", big_states[:5])
# print("First 5 Small States:", small_states[:5])

# # 4. Mathematical Verification
# # The sum of these two counts should match the length of your 'actual_states_cols'
# if total_states_processed == len(df_states.columns):
#     print("\n✅ SUCCESS: All states accounted for with no double-counting.")
# else:
#     print("\n⚠️ WARNING: Some columns were missed or duplicated.")

# CREATE THE ANALYSIS DATAFRAME
# This includes the Heavy Hitters + the "Other States" bucket
df_analysis = df_states_clean[big_states].copy()
df_analysis['Other States'] = df_states_clean[small_states].sum(axis=1)

# Create a dictionary of the "Ugly" name vs your "Short" name
short_names = {
    'Federal Offshore--Gulf of America': 'Gulf of Mexico',
    'Alaska North Slope Crude Oil Production (Thousand Barrels per Day)': 'Alaska North Slope'
}
# Apply the change
df_analysis.rename(columns=short_names, inplace=True)

# Drop the sub-regions to prevent double-counting - only Alaska now
columns_to_drop = ['Alaska North Slope', 'Alaska South']

# Only drop if they actually exist in your current columns
df_analysis.drop(columns=[col for col in columns_to_drop if col in df_analysis.columns], inplace=True)

# Verify the result
#print("Remaining Alaska-related columns:", [c for c in df_analysis.columns if "Alaska" in c])

# Double check the math-  Print the exact names and means of what ended up in 'small_states'
# print("--- THE SMALL STATES BUCKET CONTENTS ---")
# small_state_check = df_states_clean[small_states].mean().sort_values(ascending=False)
# print(small_state_check)

# print(f"\nTotal sum of these means: {small_state_check.sum():.2f}")

# print(df_analysis.head())
# print(df_analysis.shape) # should be 25

print("--- US Oil Production Leaderboard (1981-Present) ---")
summary_stats = (df_analysis.describe()).T
print(summary_stats[['mean', 'min', 'max']].sort_values(by='mean', ascending=False).round(0))

# Print the top 5 by the most recent month's production
print("--- Current Top 5 Producers ---")
print(df_analysis.iloc[-1].sort_values(ascending=False).head(5).round(0))