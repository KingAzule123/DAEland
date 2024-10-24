# A simple quiz program based on your algorithm

# Step 1: Define a function to display a message
def display_message(message):
    """Displays a message to the user."""
    print(message)

# Step 2: Define a function for the quiz logic
def start_quiz():
    """Starts the quiz and handles the questions and answers."""
    
    # A list of questions with corresponding answers
    questions = [
    {"question": "What is the capital of France?", "answer": "Paris"},
    {"question": "What is 5 + 7?", "answer": "12"},
    {"question": "What color is the sky on a clear day?", "answer": "Blue"},
    {"question": "What is the square root of 16?", "answer": "4"},
    {"question": "Who wrote 'To Kill a Mockingbird'?", "answer": "Harper Lee"}  # This line was incompletess
]

    
    # Variable to track the number of wrong answers
    wrong_answers = 0
    # Maximum number of allowed wrong answers
    max_wrong_answers = 3

    for q in questions:
        # Ask the question
        user_answer = input(q["question"] + " ")
        
        # Check the user's answer
        if user_answer.lower() != q["answer"].lower():
            wrong_answers += 1
            print(f"Wrong! You have {wrong_answers} wrong answers so far.")
        
        # Check if the user has exceeded the maximum wrong answers
        if wrong_answers > max_wrong_answers:
            display_message("You have failed the quiz. Better luck next time!")
            return  # Exit the quiz
    
    # If all questions are answered and wrong answers are within limit
    if wrong_answers <= max_wrong_answers:
        display_message("Congratulations! You passed the quiz!")

# Step 3: The main loop to handle the quiz start and restart
def main():
    """Main function to start and restart the quiz."""
    while True:
        # Show the start button (simulated by asking if the user wants to start)
        start = input("Press 's' to start the quiz: ")
        
        if start.lower() == 's':
            # Start the quiz
            start_quiz()
        
        # Ask the user if they want to restart
        restart = input("Do you want to restart the quiz? (y/n): ")
        if restart.lower() != 'y':
            break  # Exit the program if they don't want to restart

# Call the main function to start the program
main()
